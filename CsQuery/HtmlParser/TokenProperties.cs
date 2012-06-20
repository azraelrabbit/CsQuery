﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsQuery.HtmlParser
{
    [Flags]
    public enum TokenProperties
    {
        // the element is an HTML block-level element
        
        BlockElement=1,

        // the attribute is a boolean property e.g. 'checked'

        BooleanProperty=2,
        
        // the tag is automatically closing, e.g. 'p'.

        AutomaticClose=4,
        
        // the tag may not have children

        ChildrenNotAllowed=8,

        // the tag may not have HTML children (but could possibly have children)

        HtmlChildrenNotAllowed=16
    }
}