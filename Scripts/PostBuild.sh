echo "LB - ."
echo "LB - POST BUILD SHELL SCRIPT"

echo "LB - PWD : "
pwd

echo "LB - ===================================="
echo "LB - ENVIRONMENT : "
env
echo "LB - ===================================="

echo "LB - Fastlane version : "
fastlane -v

echo "LB - Upload to google play store :"
#fastlane supply --aab ../bin/Rafts.aab --track internal --release_status draft

echo "LB - ."
