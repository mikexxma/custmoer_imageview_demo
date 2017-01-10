using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace SharpText_Demo
{
    [Register("sharpText_Demo.SquareImageView")]
    public class SquareImageView : ImageView
    {
        public SquareImageView(Context context):base(context)
        {
          
        }

        public SquareImageView(Context context, IAttributeSet attrs):base(context,attrs,0)
        {
           
        }

        public SquareImageView(Context context, IAttributeSet attrs, int defStyle):base(context,attrs,defStyle)
        {
           
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            SetMeasuredDimension(GetDefaultSize(0, widthMeasureSpec), GetDefaultSize(0, heightMeasureSpec));
            int childWidthSize = MeasuredWidth;
            //SET  height = width
            heightMeasureSpec = widthMeasureSpec = MeasureSpec.MakeMeasureSpec(childWidthSize, MeasureSpecMode.Exactly);
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        }
    }
}