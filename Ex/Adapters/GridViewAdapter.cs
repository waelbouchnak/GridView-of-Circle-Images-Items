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
using Android.Graphics;
using Refractored.Controls;
 
namespace Ex.Adapters
{

    public class GridViewAdapter : BaseAdapter
    {
        private static int NumberOfItems = 20;

        Context context;
        public GridViewAdapter(Context c)
        {
            context = c;
        }

        public override int Count
        {
            get { return GridViewAdapter.NumberOfItems ; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

         public override View GetView(int position, View convertView, ViewGroup parent)
        {
            CircleImageView imageView;

            if (convertView == null)
            {
                imageView = new CircleImageView(context);
                imageView.LayoutParameters = new GridView.LayoutParams(500, 500);
                imageView.SetScaleType(CircleImageView.ScaleType.CenterCrop);
                imageView.SetPadding(15, 15, 15, 15);
                Random rand = new Random();
                imageView.SetImageResource(PicturesList[rand.Next(10)]);
                if (position % 2 == 0)
                {
                    // Random Photos
                    //imageView.SetImageResource(PicturesList[rand.Next(10)]);
                }
                else
                {
                    //imageView.SetImageResource(Resource.Drawable.Pic_0);
                    //imageView.SetColorFilter(Color.Argb(255, rand.Next(256), rand.Next(256), rand.Next(256))); //Random Colors 
                    //imageView.Elevation = float.Parse("1"); // Shadow Ombres
                }
            }
            else
            { imageView = (CircleImageView)convertView; }

            return imageView;

        }
        int[] PicturesList = {
        Resource.Drawable.Pic_0, Resource.Drawable.Pic_2,
        Resource.Drawable.Pic_1, Resource.Drawable.Pic_3,
        Resource.Drawable.Pic_2, Resource.Drawable.Pic_4,
        Resource.Drawable.Pic_0, Resource.Drawable.Pic_2,
        Resource.Drawable.Pic_1, Resource.Drawable.Pic_3,
      

    };

    }
}