﻿#region

using db;
using MySql.Data.MySqlClient;
using System;
using System.Text;
using System.Xml;

#endregion

namespace server.friends
{
    internal class acceptRequest : RequestHandler
    {
        protected override void HandleRequest()
        {
            WriteErrorLine("Not implemented!");
            throw new NotImplementedException();
        }
    }
}