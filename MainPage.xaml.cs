namespace Examen_PMO
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();
            GetLocation();
        }
        async void GetLocation()
        {
            try
            {
                // Solicitar permiso de acceso a la ubicación
                var request = new GeolocationRequest(GeolocationAccuracy.Best);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    // Si se obtiene la ubicación, puedes usarla como desees
                    double latitude = location.Latitude;
                    double longitude = location.Longitude;
                    
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // La geolocalización no es compatible en este dispositivo/platforma
                Console.WriteLine($"Geolocalización no es soportada: {fnsEx.Message}");
            }
            catch (PermissionException pEx)
            {
                // No se otorgó permiso para acceder a la ubicación
                Console.WriteLine($"Permiso de ubicación no otorgado: {pEx.Message}");
            }
            catch (Exception ex)
            {
                // Otras excepciones
                Console.WriteLine($"Error al obtener la ubicación: {ex.Message}");
            }
        }
        private async void btnprocesar_Clicked(object sender, EventArgs e) { }

        private async void btntomar_Clicked(object sender, EventArgs e)
        { }
    }

}
