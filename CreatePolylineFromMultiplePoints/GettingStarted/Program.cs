using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;

namespace GettingStarted
{
    public class Class1 : IExtensionApplication
    {
        #region IExtensionApplication Members

        public void Initialize()
        {
            throw new Exception("The method is not implemented.");
        }

        public void Terminate()
        {
            throw new Exception("The method or operation is not implemented.")
        }
        #endregion
    }
}
