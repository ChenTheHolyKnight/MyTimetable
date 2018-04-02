using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace ClassTimeTable
{
    [Activity(Label = "ClassTimeTable", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //set the top menu bar
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "MyTimetable";

            //set the bottom menu bar.
            var weekToolbar = FindViewById<Toolbar>(Resource.Id.week_toolbar);
            weekToolbar.InflateMenu(Resource.Menu.week_menus);
            weekToolbar.MenuItemClick += (s, e) =>
            {
                //need to implement for clicking on the Monday....
            };

            

        }
        #region | Menu |
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menu,menu);
            return base.OnCreateOptionsMenu(menu);
        }


        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_Add:
                    ActionBar.Title = "Add";
                    break;
                case Resource.Id.menu_Delete:
                    ActionBar.Title = "Delete";
                    break;
                case Resource.Id.menu_Edit:
                    ActionBar.Title = "Edit";
                    break;
                default:
                    break;
            }

            return base.OnOptionsItemSelected(item);

        }
        #endregion
    }
}

