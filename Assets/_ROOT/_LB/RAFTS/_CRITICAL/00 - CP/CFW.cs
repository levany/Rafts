using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace LB.RAFTS
{
    #if Unity_EDITOR
    [ExecuteAlways]
    #endif
    public partial class CFW : MonoBehaviour
    {
        ///////// CP
        
        public static async void Run(CCore core)
        {
            Debug.Log("<color=cyan>=================================</color>");

            core.Steps.Clear();
            var steps = core.GetType().GetProperties().Where(x => x.PropertyType == typeof(CStep)).ToList();

            // Populate steps
            
            foreach (var stepProp in steps)
            {
                var step    = stepProp.GetValue(core) as CStep;
                step.Name   = stepProp.Name;
                step.CCore  = core;
                
                core.Steps.Add(step);
            }

            // Run steps

            foreach (var step in core.Steps)
            {
                await step.Run();
            }
        }
    }
    
    public partial class CEntity
    {
        
    }
    
    public partial class CCore : CEntity
    {
        public List<CStep> Steps = new List<CStep>();
    }
        
    public partial class CAction
    {
        public string        Name;
        public Action<CStep> Action;
    }
    
    public partial class CTask
    {
        public string            Name;
        public Func<CStep, Task> Task;
    }

    public partial class CStep
    {
        // Members

        public string        Name { get; set; }
        public List<String>  Tags = new List<string>();

        public List<CTask>   Tasks   = new List<CTask>();

        private string[]     Lines;
        
        public CEntity[]     LastResults;
        public CEntity       LastResult  => LastResults?.FirstOrDefault();
        
        // Properties
        
        public CCore CCore { get; set; }
        
        // Factory

        public CStep Tweek(Action<CStep> action)
        {
            action.Invoke(this);
            return this;
        }

        public CStep Append(string name, Func<CStep, Task> theTask)
            => 
                Tweek(s => s.Tasks.Add(new CTask()
                {
                    Name  = name,
                    Task  = async (step) =>
                    {
                        try
                        {
                            await theTask?.Invoke(step);
                        }
                        catch (Exception e)
                        {
                            Debug.LogError("<color=red><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<</color>");
                            throw;
                        }
                        finally
                        {
                            // Debug.Log(".");
                        }
                    }
                }));
        
        /////// API
        
        public CStep NAME  (string          name)   => Tweek(s => s.Name        = name);
        public CStep TAGS  (params string[] tags)   => Tweek(s => s.Tags.AddRange(tags));
        public CStep LINES (params string[] lines)  
            => 
            Append("Lines",
                    async s =>
                    {
                        s.Lines = lines;

                        foreach (var line in Lines)
                        {
                            s.Log($"<color=yellow>{line}</color>");
                        } 
                    });
        
        public CStep NOTE (params object[] messages)  
            =>
                Append("Note",
                    async s =>
                    {
                        foreach (var message in messages)
                        {
                            string str = message.ToString();
                            
                            if (str.Contains("[V]"))
                            {
                                str = str.Replace("[V]","<color=green>[V]</color>");
                            }
                            if (str.Contains("[X]"))
                            {
                                str = str.Replace("[X]","<color=red>[V]</color>");
                            }
                            if (str.Contains("[~]"))
                            {
                                str = str.Replace("[V]","<color=yellow>[V]</color>");
                            }
                            if (str.Contains("[ ]"))
                            {
                                str = str.Replace("[ ]","<b>[ ]</b>");
                            }
                            
                            s.Log(str);
                        }
                    });
        
        public CStep TASK (Func <CStep, Task> TaskFunk) => TASK(null, TaskFunk);
        public CStep TASK (string name, Func <CStep, Task> TaskFunk)  
            =>
                Append("Task" + ((name != null) ? $" - \"{name}\" " : ""), 
                       async s =>
                       {
                            // Pre Actions
                            await TaskFunk.Invoke(s);
                            // Post Actions
                       });

        // public CStep PRINT (Action<CStep> OnPrint = null)  
        //     =>
        //         Append("Print",
        //             s =>
        //             {
        //                 // Validations
        //             
        //                 if (this.Lines        == null
        //                 ||  this.Lines.Length == 0)
        //                     return;
        //                     
        //                 // Print operation 
        //
        //                 var printer       = CP.Instance.CCore.Print(this.Lines);
        //                 printer.DumpSteps = true;
        //                 printer.Execute();
        //                 
        //                 
        //                 this.LastResults = printer.LastResults;
        //         
        //                 // Log results
        //         
        //                 if (LastResults != null)
        //                 {
        //                     s.Log("Printed: ");
        //                     foreach (var result in LastResults)
        //                     {
        //                         string[] tree = result.E.DumpTree().Split('\n');
        //
        //                         foreach (var line in tree)
        //                             s.Log("<color=lime>" + line + "</color>");
        //                     }   
        //                 }
        //         
        //                 // OnPrint callback
        //                 
        //                 OnPrint?.Invoke(s);
        //             });
        

        // CP

        public async Task Run()
        {
            if (this.Name.StartsWith("___"))
            {   
                Debug.Log($"<b>================================================ {this.Name.Trim('_')}</b>");
            }
            else if (this.Name.StartsWith("__"))
            {
                Debug.Log($"<b>------------------------------- {this.Name.Trim('_')}</b>");
            }
            else if (this.Name.StartsWith("MARK"))
            {
                Debug.Log($"<color=cyan><b> <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< {this.Name} </b></color>");
            }
            else
            {
                Debug.Log($"<b>[ {Name} ]</b>");
            }
            
            foreach (var cJob in this.Tasks)
            {
                Debug.Log($"<color=orange>>{cJob.Name}</color>");
                
                await cJob.Task.Invoke(this);
            }
        }
        
        // Helpers

        /// <summary>
        /// Example : s.Log("message", "color=red");
        /// </summary>
        public void Log(object message, string format = null)
        {
            string[] lines;
            lines = message.ToString().Split('\n');

            foreach (var line in lines)
            {
                var text = line;
                text     = $"        {line}";
                
                if (format != null)
                {
                    string[] formats = format.Split(" ");
                    
                    if (format.Contains("color="))
                    {
                        string f = formats.First(f => f.StartsWith("color="));
                        string color = f.Replace("color=", "");
                        text = $"<color={color}>{text}</color>";
                    }
                }
                    
                Debug.Log(text);
            }
        }    
    }   
}