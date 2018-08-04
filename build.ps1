Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/barcode -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client



(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj).replace('<Authors>Swagger</Authors>', "<Authors>Cloudmersive</Authors>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj).replace('<Company>Swagger</Company>', "<Company>Cloudmersive</Company>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj).replace('<AssemblyTitle>Swagger Library</AssemblyTitle>', "<AssemblyTitle>Cloudmersive Barcode API Client</AssemblyTitle>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj).replace('<Description>A library generated from a Swagger doc</Description>', "<Description>Barcode APIs let you generate barcode images, and recognize values from images of barcodes.</Description>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj).replace('<TargetFramework>net45</TargetFramework>', "<TargetFramework>netcoreapp2.1</TargetFramework>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj





& dotnet build ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj -c Release
& dotnet pack ./client/src/Cloudmersive.APIClient.NETCore.Barcode/Cloudmersive.APIClient.NETCore.Barcode.csproj -c Release