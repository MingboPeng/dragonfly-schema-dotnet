import subprocess
import os

NUGET_API_KEY = os.getenv('NUGET_API_KEY')

print("Getting DragonflySchema.dll version")
outputs = subprocess.check_output("powershell (Get-Item src/DragonflySchema/bin/Release/DragonflySchema.dll).VersionInfo.ProductVersion")
BUILD_VERSION = str(outputs)[2:-5]
print("raw output of version checking: " + str(outputs))
print("cleaned new build version: " + BUILD_VERSION)

try:
    nuget_pack = f"nuget pack src/DragonflySchema/DragonflySchema.csproj -Properties Configuration=Release -Version {BUILD_VERSION} -Verbosity detailed"
    subprocess.check_output(nuget_pack)

    nuget_push = f"nuget push DragonflySchema.{BUILD_VERSION}.nupkg -ApiKey {NUGET_API_KEY} -Source https://api.nuget.org/v3/index.json"
    subprocess.check_output(nuget_push)

except Exception as e:
    print(str(e))
    raise Exception(e)

print(f"Deployed to https://www.nuget.org/packages/DragonflySchema/{BUILD_VERSION}")
print("nuget usually takes a few miniutes to process this new package until it shows up from above link")