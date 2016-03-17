﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenML.Tests
{
    [TestClass]
    public class BaseApiConnectorTest
    {
        public BaseApiConnectorTest()
        {
            //ReadOnlyKey for dotnet test account
            Connector = new OpenMlConnector("57e587337295cc384add1de665563e29");
        }

        public OpenMlConnector Connector { get; set; }
    }
}
