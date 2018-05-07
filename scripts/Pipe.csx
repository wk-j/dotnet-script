#! "netcoreapp2.0"
#r "nuget: NetStandard.Library, 2.0.0"

using (var streamReader = new StreamReader(Console.OpenStandardInput())) {
    Write(streamReader.ReadToEnd().ToUpper());
}