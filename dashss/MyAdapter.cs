using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dashss
{
    class MyAdapter : RecyclerView.Adapter
    {
        private FriendsDetails _friendsDetails;
        private Context context;

        public MyAdapter(FriendsDetails friendsDetails, Context context)
        {
            _friendsDetails = friendsDetails;
            this.context = context;
        }

        public override int ItemCount => _friendsDetails.NumbFriends;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MyViewHolder viewHolder = holder as MyViewHolder;
            viewHolder.Binddata(_friendsDetails, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.recycleviewdata, parent, false);
            return new MyViewHolder(view);
        }
    }
    class MyViewHolder : RecyclerView.ViewHolder
    {
        public ImageView friendImage;
        public TextView friendNameText;
        public TextView friendDescriptionText;
        public TextView friendmoradetailText;

        public RelativeLayout relativeLayout2;
        public MyViewHolder(View itemView) : base(itemView)
        {
            friendImage = itemView.FindViewById<ImageView>(Resource.Id.imageWhishlist);
            friendNameText = itemView.FindViewById<TextView>(Resource.Id.textView1);
            friendDescriptionText = itemView.FindViewById<TextView>(Resource.Id.textView2);
            friendmoradetailText= itemView.FindViewById<TextView>(Resource.Id.textView3);






        }

        

        internal void Binddata(FriendsDetails friendsDetails, int position)
        {
            friendImage.SetImageResource(friendsDetails[position].PhotoId);
            friendNameText.Text = friendsDetails[position].Fname;
            friendDescriptionText.Text = friendsDetails[position].Fdescription;
            friendmoradetailText.Text = friendsDetails[position].Moradetail;
        }
    }
}