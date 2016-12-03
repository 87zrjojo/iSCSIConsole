/* Copyright (C) 2012-2016 Tal Aloni <tal.aloni.il@gmail.com>. All rights reserved.
 * 
 * You can redistribute this program and/or modify it under the terms of
 * the GNU Lesser Public License as published by the Free Software Foundation,
 * either version 3 of the License, or (at your option) any later version.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace ISCSI.Client
{
    internal class ConnectionParameters
    {
        public ushort CID; // connection ID, generated by the initiator
        
        public int InitiatorMaxRecvDataSegmentLength = ISCSIClient.DeclaredParameters.MaxRecvDataSegmentLength;
        public int TargetMaxRecvDataSegmentLength = DefaultParameters.Connection.MaxRecvDataSegmentLength;

        public bool StatusNumberingStarted;
        public uint ExpStatSN;
    }
}