using System;
using System.Collections.Generic;
using System.Text;

namespace MFW3D
{
    /// <summary>
    /// 自定义点图形
    /// </summary>
    public struct PointSpriteVertex
    {
        public float xval;
        public float yval;
        public float zval;
        public float PointSize;
        public int color;

        public PointSpriteVertex(float fxval, float fyval, float fzval, float psize, int icolor)
        {
            xval = fxval;
            yval = fyval;
            zval = fzval;
            PointSize = psize;
            color = icolor;
        }
    }
}
