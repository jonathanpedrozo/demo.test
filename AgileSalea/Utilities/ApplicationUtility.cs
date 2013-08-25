using System;
using System.Text;
using AgileSalea.Models;

namespace AgileSalea.Utilities
{
    public static class ApplicationUtility
    {
        public static string FormatURL(string PathWithoutVirtualDirectoryName)
        {
            ApplicationInformation appInfomation
                = ApplicationInformation.GetInstance();
            string DeploymentVirtualDirectory
                = appInfomation.DeploymentVirtualDirectory;

            if (DeploymentVirtualDirectory == "")
            {
                return PathWithoutVirtualDirectoryName;
            }

            StringBuilder SB = new StringBuilder();
            SB.Append("/");
            SB.Append(appInfomation.DeploymentVirtualDirectory);
            SB.Append("/");
            SB.Append(PathWithoutVirtualDirectoryName);

            return SB.ToString();
        }
    }
}
