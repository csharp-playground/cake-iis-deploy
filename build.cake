#addin "Cake.WebDeploy"

var target = Argument("target", "DeployUrl");

Task("DeployUrl")
    .Description("Deploy to Azure using a custom Url")
    .Does(() =>
    {
        var settings = new DeploySettings()
        {
            SourcePath = "../angular2-template",
            PublishUrl = "https://<ip>-V:8172/msdeploy.axd",
            SiteName = "SiteName",
            Username = "User",
            Password = "Password"
        };
        DeployWebsite(settings);
    });

Task("Default")
    .IsDependentOn("DeployUrl");

RunTarget(target);