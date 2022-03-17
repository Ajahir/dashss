using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dashss
{
    class Friends
    {
        public Friends(int id, string name, string description,string moradetail)
        {
            PhotoId = id;
            Fname = name;
            Fdescription = description;
            Moradetail = moradetail;

        }

        public int PhotoId { get; }
        public string Fname { get; }
        public string Fdescription { get; }
        public string Moradetail { get; }
    }
    class FriendsDetails
    {
        static Friends[] frnd = {

            new Friends(Resource.Drawable.facebok, "Ross Geller", "The Dinosour Guy", "great"),
            new Friends(Resource.Drawable.facebok, "Rachel Green", "Raquel", "good"),
            new Friends(Resource.Drawable.facebok, "Chandler Bing", "Miss Chanandler Bong", "ecelent"),
            new Friends(Resource.Drawable.facebok, "Monica Geller", "The Chef", "gog"),
            new Friends(Resource.Drawable.facebok, "Joey Tribbiani", "Kan Adams", "jhh"),
        };
        private Friends[] mfrnd;

        Random random;

        public FriendsDetails()
        {
            mfrnd = frnd;
            random = new Random();
        }

        public int NumbFriends
        {

            get { return mfrnd.Length; }
        }

        public Friends this[int i]
        {
            get { return mfrnd[i]; }
        }

        public int RandomSwap()
        {
            Friends tempfrnd = mfrnd[0];

            int mrandom = random.Next(1, mfrnd.Length);

            mfrnd[0] = mfrnd[mrandom];
            mfrnd[mrandom] = tempfrnd;

            return mrandom;
        }

        public void Suffle()
        {
            for (int i = 0; i < mfrnd.Length; i++)
            {
                Friends tempfrnd = mfrnd[i];


                int mrandom = random.Next(1, mfrnd.Length);

                mfrnd[i] = mfrnd[mrandom];
                mfrnd[mrandom] = tempfrnd;
            }

        }
    }
}
