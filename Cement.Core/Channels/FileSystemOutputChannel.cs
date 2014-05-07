﻿using Cement.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cement.Channels
{
    public class FileSystemOutputChannel : FileSystemChannelBase, IOutputChannel
    {
        public FileSystemOutputChannel(IChannelContext channelContext, IFileSystem fileSystem)
            : base(channelContext, fileSystem)
        { }

        public void Send(Messages.IMessage message)
        {
            Uri uri = GetChannelUri();
            using (var outputStream = fileSystem.OpenWrite(uri.LocalPath))
            {
                message.Body.CopyTo(outputStream);
            }
        }
    }
}