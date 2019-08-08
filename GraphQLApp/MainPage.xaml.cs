using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Request;
using GraphQL.Common.Response;
using Xamarin.Forms;



namespace GraphQLApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            loadData();
        }

        private async void loadData()
        {
            var graphQLRequest = new GraphQLRequest
            {
                Query = @"
                {
                  allFilms {
                    films {
                      title
                      director
                    }
                  }
                }"
            };

            var graphQLClient = new GraphQLClient(GraphQLApp.Constants.url);
            var graphQLResponse = await graphQLClient.PostAsync(graphQLRequest);
            FilmsList.ItemsSource = graphQLResponse.Data.allFilms.films.ToObject<List<Film>>();
        }
    }
}
