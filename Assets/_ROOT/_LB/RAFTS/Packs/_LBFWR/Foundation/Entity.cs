using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  LB.RAFTS
{
    public interface IEntity
    {
        Entity E {get;}
    }

    public class Entity : IEntity
    {
        public Entity E => this;
        
        // Members
        
        public string       ID;
        public List<string> Tags = new();
        public EntityLink   Link = new();
        
        public string       Name;

        // LIfecycle

        public Entity(string name = null, params string[] tags)
        {
            if (name == null)
                name = this.GetType().Name;
                
            this.Name = name;
            this.ID   = "ID_" + name;
            this.Tags .AddRange(tags);
            
            this.Link.Entity = this;
            
            // Debug.Log(this.GetType() + this.Name + "CTOR");
        }
    }

    public class EntityLink
    {
        public IEntity       Parent;
        public List<IEntity> Children = new List<IEntity>();
        
        public IEntity       Entity;
        
        public void AddChild(IEntity child)
        {
            this.Children.Add(child);
            child.E.Link.Parent = this.Entity;
        } 
    }

}
