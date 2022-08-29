﻿using SeCli.libse.Cea708.Commands;

namespace SeCli.libse.Cea708
{
    public class CommandState
    {
        public List<ICea708Command> Commands { get; set; }
        public int StartLineIndex { get; set; }

        public CommandState()
        {
            Commands = new List<ICea708Command>();
        }
    }
}
