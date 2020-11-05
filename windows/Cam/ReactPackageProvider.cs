using Microsoft.ReactNative.Managed;
using Microsoft.ReactNative;

using System;

namespace Cam
{
    public sealed class ReactPackageProvider : IReactPackageProvider
    {
        public void CreatePackage(IReactPackageBuilder packageBuilder)
        {
            packageBuilder.AddViewManagers();

            Console.WriteLine("VIEWIE");
        }
    }
}
