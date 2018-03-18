using System;
using System.Collections.Generic;
using System.Text;

namespace XMemo2
{
    public class MemoHolder
    {
        // singleton
        public static MemoHolder Current { get; } = new MemoHolder();

        public Memo Memo { get; set; }
    }
}
