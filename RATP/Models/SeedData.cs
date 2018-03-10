using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RATP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcLineContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcLineContext>>()))
            {

                // If there are no movies in the DB
                if (!context.Line.Any())
                {
                    context.Line.AddRange(
                        new Line
                        {
                            Code = "1",
                            Name = "Métro 1",
                            Directions = "La Defense / Chateau de Vincennes"
                        },
                        new Line
                        {
                            Code = "2",
                            Name = "Métro 2",
                            Directions = "Porte Dauphine / Nation"
                        },
                        new Line
                        {
                            Code = "3",
                            Name = "Métro 3",
                            Directions = "Pont de Levallois - Becon / Gallieni"
                        },
                        new Line
                        {
                            Code = "3b",
                            Name = "Métro 3b",
                            Directions = "Gambetta / Porte des Lilas"
                        },
                        new Line
                        {
                            Code = "4",
                            Name = "Métro 4",
                            Directions = "Mairie de Montrouge / Porte de Clignancourt"
                        },
                        new Line
                        {
                            Code = "5",
                            Name = "Métro 5",
                            Directions = "Place d'Italie / Bobigny - Pablo Picasso"
                        },
                        new Line
                        {
                            Code = "6",
                            Name = "Métro 6",
                            Directions = "Charles de Gaulle - Etoile / Nation"
                        },
                        new Line
                        {
                            Code = "7",
                            Name = "Métro 7",
                            Directions = "Villejuif-L. Aragon / Mairie d'Ivry / la Courneuve - 8 Mai 1945"
                        },
                        new Line
                        {
                            Code = "7b",
                            Name = "Métro 7b",
                            Directions = "Louis Blanc / Pre-Saint-Gervais"
                        },
                        new Line
                        {
                            Code = "8",
                            Name = "Métro 8",
                            Directions = "Pointe du Lac / Balard"
                        },
                        new Line
                        {
                            Code = "9",
                            Name = "Métro 9",
                            Directions = "Mairie de Montreuil / Pont de Sevres"
                        },
                        new Line
                        {
                            Code = "10",
                            Name = "Métro 10",
                            Directions = "Gare d'Austerlitz / Boulogne - Pont de Saint Cloud"
                        },
                        new Line
                        {
                            Code = "11",
                            Name = "Métro 11",
                            Directions = "Chatelet / Mairie des Lilas"
                        },
                        new Line
                        {
                            Code = "12",
                            Name = "Métro 12",
                            Directions = "Front Populaire / Mairie d'Issy"
                        },
                        new Line
                        {
                            Code = "13",
                            Name = "Métro 13",
                            Directions = "St-Denis-Universite/Les Courtilles / Chatillon - Montrouge"
                        },
                        new Line
                        {
                            Code = "14",
                            Name = "Métro 14",
                            Directions = "Olympiades / Saint-Lazare"
                        },
                        new Line
                        {
                            Code = "Fun",
                            Name = "Métro Fun",
                            Directions = "Funiculaire"
                        },
                        new Line
                        {
                            Code = "Orv",
                            Name = "Métro Orv",
                            Directions = "Orly Sud / Antony-RER",
                        }
                    );
                }

                if (!context.Station.Any())
                {
                    context.Station.AddRange(
                        new Station
                        {
                            Name = "Chateau de Vincennes",
                            Latitude = 48.844089775967,
                            Longitude = 2.4424854671358,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Berault",
                            Latitude = 48.845368750157,
                            Longitude = 2.4282445096205,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Saint-Mande",
                            Latitude = 48.846238256621,
                            Longitude = 2.4189998281093,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Porte de Vincennes",
                            Latitude = 48.847016518419,
                            Longitude = 2.4108168823348,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Nation",
                            Latitude = 48.848111231576,
                            Longitude = 2.3980040127977,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Reuilly-Diderot",
                            Latitude = 48.847522955734,
                            Longitude = 2.3874904434685,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Gare de Lyon",
                            Latitude = 48.845559787083,
                            Longitude = 2.3734492049632,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Bastille",
                            Latitude = 48.852975674654,
                            Longitude = 2.3692188244433,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Saint-Paul (Le Marais)",
                            Latitude = 48.855134518235,
                            Longitude = 2.3613343390677,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Hotel de Ville",
                            Latitude = 48.85735592717,
                            Longitude = 2.3520735668587,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Chatelet",
                            Latitude = 48.858389963549,
                            Longitude = 2.3474837299933,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Louvre-Rivoli",
                            Latitude = 48.860879857594,
                            Longitude = 2.3409732758179,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Palais-Royal (Musee du Louvre)",
                            Latitude = 48.862371821524,
                            Longitude = 2.3365736007364,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Tuileries",
                            Latitude = 48.8647801625,
                            Longitude = 2.3290949544294,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Concorde",
                            Latitude = 48.86548939089,
                            Longitude = 2.3214117892138,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Champs-Elysees-Clemenceau",
                            Latitude = 48.867744026069,
                            Longitude = 2.3141227803741,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Franklin-Roosevelt",
                            Latitude = 48.868812631861,
                            Longitude = 2.3099263244705,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "George V",
                            Latitude = 48.872045619426,
                            Longitude = 2.300769185645,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Charles de Gaulle-Etoile",
                            Latitude = 48.873715268311,
                            Longitude = 2.2947595628499,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Argentine",
                            Latitude = 48.875672485988,
                            Longitude = 2.2894441644814,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Porte Maillot",
                            Latitude = 48.878006176279,
                            Longitude = 2.2824656400013,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Les Sablons (Jardin d'acclimatation)",
                            Latitude = 48.881299185491,
                            Longitude = 2.2719151760178,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Pont de Neuilly",
                            Latitude = 48.885506109418,
                            Longitude = 2.2585274701974,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Esplanade de la Defense",
                            Latitude = 48.888358060166,
                            Longitude = 2.2499372128628,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "La Defense (Grande Arche)",
                            Latitude = 48.892005654003,
                            Longitude = 2.2369831238174,
                            LineID = "1"
                        },
                        new Station
                        {
                            Name = "Nation",
                            Latitude = 48.848111231576,
                            Longitude = 2.3980040127977,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Avron",
                            Latitude = 48.850065501068,
                            Longitude = 2.4993952858883,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Alexandre-Dumas",
                            Latitude = 48.856426348325,
                            Longitude = 2.394554257655,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Philippe Auguste",
                            Latitude = 48.85837884147,
                            Longitude = 2.3897347327397,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Pere-Lachaise",
                            Latitude = 48.863161205064,
                            Longitude = 2.3872604001844,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Menilmontant",
                            Latitude = 48.865705787623,
                            Longitude = 2.3844293751632,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Couronnes",
                            Latitude = 48.868861951045,
                            Longitude = 2.3801953930624,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Belleville",
                            Latitude = 48.871945797975,
                            Longitude = 2.3767510413738,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Colonel Fabien",
                            Latitude = 48.770407979252,
                            Longitude = 2.4846381105808,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Jaures",
                            Latitude = 48.882876216213,
                            Longitude = 2.3705863361654,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Stalingrad",
                            Latitude = 48.884071986364,
                            Longitude = 2.3688700627778,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "La Chapelle",
                            Latitude = 48.884388698358,
                            Longitude = 2.3592765642767,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Barbes-Rochechouart",
                            Latitude = 48.883931769934,
                            Longitude = 2.3493557085996,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Anvers",
                            Latitude = 48.882871690181,
                            Longitude = 2.3441635728004,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Pigalle",
                            Latitude = 48.882027089626,
                            Longitude = 2.3372138017479,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Blanche",
                            Latitude = 48.88371663448,
                            Longitude = 2.3335889584918,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Place de Clichy",
                            Latitude = 48.883203999877,
                            Longitude = 2.3272660246411,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Rome",
                            Latitude = 48.882070833937,
                            Longitude = 2.32039833931,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Villiers",
                            Latitude = 48.881405100411,
                            Longitude = 2.3161470509074,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Monceau",
                            Latitude = 48.880576890748,
                            Longitude = 2.3094159461648,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Courcelles",
                            Latitude = 48.879398119761,
                            Longitude = 2.3038162556497,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Ternes",
                            Latitude = 48.878228040508,
                            Longitude = 2.2981214325822,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Charles de Gaulle-Etoile",
                            Latitude = 48.873715268311,
                            Longitude = 2.2947595628499,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Victor Hugo",
                            Latitude = 48.828012751354,
                            Longitude = 2.2722000700486,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Porte Dauphine (Marechal de Lattre de Tassigny)",
                            Latitude = 48.871792216418,
                            Longitude = 2.2748699611957,
                            LineID = "2"
                        },
                        new Station
                        {
                            Name = "Gallieni (Parc de Bagnolet)",
                            Latitude = 48.863262526501,
                            Longitude = 2.4159753685,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Porte de Bagnolet",
                            Latitude = 48.864551788204,
                            Longitude = 2.4095612716548,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Gambetta",
                            Latitude = 48.865034298018,
                            Longitude = 2.3985414869122,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Pere-Lachaise",
                            Latitude = 48.863161205064,
                            Longitude = 2.3872604001844,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Rue Saint-Maur",
                            Latitude = 48.864089405746,
                            Longitude = 2.3808997885521,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Parmentier",
                            Latitude = 48.865259856673,
                            Longitude = 2.3747570817168,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Republique",
                            Latitude = 48.867410828835,
                            Longitude = 2.363587825558,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Temple",
                            Latitude = 48.866764167815,
                            Longitude = 2.3615713270327,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Arts-et-Metiers",
                            Latitude = 48.865381176047,
                            Longitude = 2.3556449312069,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Reaumur-Sebastopol",
                            Latitude = 48.866046669631,
                            Longitude = 2.3526209540152,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Sentier",
                            Latitude = 48.867350381431,
                            Longitude = 2.3475672354151,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Bourse",
                            Latitude = 48.868600008394,
                            Longitude = 2.3410691924641,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Quatre Septembre",
                            Latitude = 48.869660572192,
                            Longitude = 2.3363282816417,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Opera",
                            Latitude = 48.872095955632,
                            Longitude = 2.3305924621304,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Havre-Caumartin",
                            Latitude = 48.873425976535,
                            Longitude = 2.3289709732966,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Saint-Lazare",
                            Latitude = 48.875420977789,
                            Longitude = 2.3266952720717,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Europe",
                            Latitude = 48.878296521173,
                            Longitude = 2.3229748428113,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Villiers",
                            Latitude = 48.881405100411,
                            Longitude = 2.3161470509074,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Malesherbes",
                            Latitude = 48.882536472892,
                            Longitude = 2.3110092430055,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Wagram",
                            Latitude = 48.883712476037,
                            Longitude = 2.3055577575143,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Pereire",
                            Latitude = 48.885085288442,
                            Longitude = 2.2980481178603,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Porte de Champerret",
                            Latitude = 48.885739159692,
                            Longitude = 2.2918606206755,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Louise Michel",
                            Latitude = 48.902167627695,
                            Longitude = 2.4404359095363,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Anatole-France",
                            Latitude = 48.892018626329,
                            Longitude = 2.2855174447945,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Pont de Levallois-Becon",
                            Latitude = 48.89730990518,
                            Longitude = 2.2807686428069,
                            LineID = "3"
                        },
                        new Station
                        {
                            Name = "Porte de Clignancourt",
                            Latitude = 48.898949767812,
                            Longitude = 2.3439748795151,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Simplon",
                            Latitude = 48.894123444666,
                            Longitude = 2.347245444443,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Marcadet-Poissonniers",
                            Latitude = 48.891543930631,
                            Longitude = 2.3493711153819,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Chateau Rouge",
                            Latitude = 48.88708628305,
                            Longitude = 2.3493700732514,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Barbes-Rochechouart",
                            Latitude = 48.883931769934,
                            Longitude = 2.3493557085996,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Gare du Nord",
                            Latitude = 48.879743064225,
                            Longitude = 2.3546008104722,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Gare de l'Est (Verdun)",
                            Latitude = 48.876417052879,
                            Longitude = 2.3589870464563,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Chateau d'Eau",
                            Latitude = 48.87245415092,
                            Longitude = 2.3560561681303,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Strasbourg-Saint-Denis",
                            Latitude = 48.869227930988,
                            Longitude = 2.3545291753858,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Reaumur-Sebastopol",
                            Latitude = 48.866046669631,
                            Longitude = 2.3526209540152,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Etienne Marcel",
                            Latitude = 48.86371036647,
                            Longitude = 2.3489831961271,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Les Halles",
                            Latitude = 48.862011970721,
                            Longitude = 2.3464764519062,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Chatelet",
                            Latitude = 48.858389963549,
                            Longitude = 2.3474837299933,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Cite",
                            Latitude = 48.855684850286,
                            Longitude = 2.3462029295287,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Saint-Michel",
                            Latitude = 48.853599907886,
                            Longitude = 2.343996241094,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Odeon",
                            Latitude = 48.852314881195,
                            Longitude = 2.3388617203363,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Saint-Germain des Pres",
                            Latitude = 48.853447237738,
                            Longitude = 2.3330463260449,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Saint-Sulpice",
                            Latitude = 48.851146355055,
                            Longitude = 2.3309628563665,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Saint-Placide",
                            Latitude = 48.847011840169,
                            Longitude = 2.3270551113551,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Montparnasse-Bienvenue",
                            Latitude = 48.842077020187,
                            Longitude = 2.3210104495551,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Vavin",
                            Latitude = 48.842059857582,
                            Longitude = 2.3288670504372,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Raspail",
                            Latitude = 48.838878378566,
                            Longitude = 2.3306784192883,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Denfert-Rochereau",
                            Latitude = 48.833315185891,
                            Longitude = 2.33344276383,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Mouton-Duvernet",
                            Latitude = 48.83219159927,
                            Longitude = 2.3304069926293,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Alesia",
                            Latitude = 48.828066019686,
                            Longitude = 2.3268274200508,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Porte d'Orleans (General Leclerc)",
                            Latitude = 48.822817060235,
                            Longitude = 2.325072625148,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Mairie de Montrouge",
                            Latitude = 48.818466337113,
                            Longitude = 2.3196432186178,
                            LineID = "4"
                        },
                        new Station
                        {
                            Name = "Bobigny-Pablo-Picasso",
                            Latitude = 48.906778225771,
                            Longitude = 2.4501111038776,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Bobigny-Pantin (Raymond Queneau)",
                            Latitude = 48.895799232549,
                            Longitude = 2.4248572983976,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Eglise de Pantin",
                            Latitude = 48.893632527974,
                            Longitude = 2.4129002660301,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Hoche",
                            Latitude = 48.886425590704,
                            Longitude = 2.4466189175576,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Porte de Pantin",
                            Latitude = 48.888583980972,
                            Longitude = 2.3924228757185,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Ourcq",
                            Latitude = 48.886923877471,
                            Longitude = 2.3866564344035,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Laumiere",
                            Latitude = 48.884931610546,
                            Longitude = 2.3790912468998,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Jaures",
                            Latitude = 48.882876216213,
                            Longitude = 2.3705863361654,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Stalingrad",
                            Latitude = 48.884071986364,
                            Longitude = 2.3688700627778,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Gare du Nord",
                            Latitude = 48.879743064225,
                            Longitude = 2.3546008104722,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Gare de l'Est (Verdun)",
                            Latitude = 48.876417052879,
                            Longitude = 2.3589870464563,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Jacques-Bonsergent",
                            Latitude = 48.87070082327,
                            Longitude = 2.3605786355873,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Republique",
                            Latitude = 48.867410828835,
                            Longitude = 2.363587825558,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Oberkampf",
                            Latitude = 48.864965303262,
                            Longitude = 2.3676324062988,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Richard-Lenoir",
                            Latitude = 48.857990084975,
                            Longitude = 2.3713194669679,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Breguet-Sabin",
                            Latitude = 48.854421916221,
                            Longitude = 2.3718619045586,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Bastille",
                            Latitude = 48.852975674654,
                            Longitude = 2.3692188244433,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Quai de la Rapee",
                            Latitude = 48.845966032406,
                            Longitude = 2.3669131797383,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Gare d'Austerlitz",
                            Latitude = 48.843863634268,
                            Longitude = 2.3640388418743,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Saint-Marcel",
                            Latitude = 48.838516743515,
                            Longitude = 2.3607275503618,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Campo-Formio",
                            Latitude = 48.835551216675,
                            Longitude = 2.3587520951914,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Place d'Italie",
                            Latitude = 48.831111838257,
                            Longitude = 2.3557961457131,
                            LineID = "5"
                        },
                        new Station
                        {
                            Name = "Nation",
                            Latitude = 48.848111231576,
                            Longitude = 2.3980040127977,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Picpus",
                            Latitude = 48.845323114614,
                            Longitude = 2.4017863137607,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Bel-Air",
                            Latitude = 48.841432006648,
                            Longitude = 2.4008691933801,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Daumesnil (Felix Eboue)",
                            Latitude = 48.839682140209,
                            Longitude = 2.3955841703467,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Dugommier",
                            Latitude = 48.839029253717,
                            Longitude = 2.3886259202812,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Bercy",
                            Latitude = 48.840542782965,
                            Longitude = 2.3794094631231,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Quai de la Gare",
                            Latitude = 48.837614675785,
                            Longitude = 2.3738521156805,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Chevaleret",
                            Latitude = 48.83496497072,
                            Longitude = 2.3680913458794,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Nationale",
                            Latitude = 48.832881288679,
                            Longitude = 2.3619094080162,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Place d'Italie",
                            Latitude = 48.831111838257,
                            Longitude = 2.3557961457131,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Corvisart",
                            Latitude = 48.829863252113,
                            Longitude = 2.3506227279321,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Glaciere",
                            Latitude = 48.831247951987,
                            Longitude = 2.343122075823,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Saint-Jacques",
                            Latitude = 48.832991691776,
                            Longitude = 2.3366828966443,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Denfert-Rochereau",
                            Latitude = 48.833315185891,
                            Longitude = 2.33344276383,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Raspail",
                            Latitude = 48.838878378566,
                            Longitude = 2.3306784192883,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Edgar-Quinet",
                            Latitude = 48.840567726204,
                            Longitude = 2.3264028152228,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Montparnasse-Bienvenue",
                            Latitude = 48.842077020187,
                            Longitude = 2.3210104495551,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Pasteur",
                            Latitude = 48.901846740843,
                            Longitude = 2.2992623155968,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Sevres-Lecourbe",
                            Latitude = 48.844960299516,
                            Longitude = 2.3113142107735,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Cambronne",
                            Latitude = 48.847699108171,
                            Longitude = 2.3020391436693,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "La Motte-Picquet-Grenelle",
                            Latitude = 48.848821266686,
                            Longitude = 2.2979529640252,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Dupleix",
                            Latitude = 48.85039257832,
                            Longitude = 2.2936483362305,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Bir-Hakeim (Grenelle)",
                            Latitude = 48.854327218552,
                            Longitude = 2.2888101037361,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Passy",
                            Latitude = 48.857534382514,
                            Longitude = 2.2855927058171,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Trocadero",
                            Latitude = 48.864419757097,
                            Longitude = 2.2880105904162,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Boissiere",
                            Latitude = 48.86685615476,
                            Longitude = 2.290038073445,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Kleber",
                            Latitude = 48.871306149088,
                            Longitude = 2.2933310208962,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "Charles de Gaulle-Etoile",
                            Latitude = 48.873715268311,
                            Longitude = 2.2947595628499,
                            LineID = "6"
                        },
                        new Station
                        {
                            Name = "La Courneuve-8-Mai-1945",
                            Latitude = 48.920514506686,
                            Longitude = 2.4102257791202,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Fort d'Aubervilliers",
                            Latitude = 48.914056745147,
                            Longitude = 2.403576334511,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Aubervilliers Pantin (4 Chemins)",
                            Latitude = 48.903898047529,
                            Longitude = 2.3924800786725,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Porte de la Villette",
                            Latitude = 48.897529156891,
                            Longitude = 2.3856442301273,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Corentin-Cariou",
                            Latitude = 48.894681541988,
                            Longitude = 2.3823021939742,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Crimee",
                            Latitude = 48.890288775045,
                            Longitude = 2.3767786489254,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Riquet",
                            Latitude = 48.888393231901,
                            Longitude = 2.374433108885,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Stalingrad",
                            Latitude = 48.884071986364,
                            Longitude = 2.3688700627778,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Louis Blanc",
                            Latitude = 48.881493428859,
                            Longitude = 2.3657752423496,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Chateau Landon",
                            Latitude = 48.878456566831,
                            Longitude = 2.3620537162489,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Gare de l'Est (Verdun)",
                            Latitude = 48.876417052879,
                            Longitude = 2.3589870464563,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Poissonniere",
                            Latitude = 48.877353095288,
                            Longitude = 2.3493814239526,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Cadet",
                            Latitude = 48.875825718038,
                            Longitude = 2.3433451245733,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Le Peletier",
                            Latitude = 48.874963058026,
                            Longitude = 2.3401567908492,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Chaussee d'Antin (La Fayette)",
                            Latitude = 48.872985824665,
                            Longitude = 2.3334262240528,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Opera",
                            Latitude = 48.872095955632,
                            Longitude = 2.3305924621304,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Pyramides",
                            Latitude = 48.866496987039,
                            Longitude = 2.3340942152591,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Palais-Royal (Musee du Louvre)",
                            Latitude = 48.862371821524,
                            Longitude = 2.3365736007364,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Pont Neuf",
                            Latitude = 48.858534102286,
                            Longitude = 2.342117238666,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Chatelet",
                            Latitude = 48.858389963549,
                            Longitude = 2.3474837299933,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Pont Marie (Cite des Arts)",
                            Latitude = 48.853463585695,
                            Longitude = 2.3573839728092,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Sully-Morland",
                            Latitude = 48.850793594742,
                            Longitude = 2.3612369937143,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Jussieu",
                            Latitude = 48.845761757311,
                            Longitude = 2.3545485949067,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Place Monge (Jardin des Plantes)",
                            Latitude = 48.843164692767,
                            Longitude = 2.3521103624151,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Censier-Daubenton",
                            Latitude = 48.840594300002,
                            Longitude = 2.3517556129467,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Les Gobelins",
                            Latitude = 48.836127439753,
                            Longitude = 2.3520811178356,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Place d'Italie",
                            Latitude = 48.831111838257,
                            Longitude = 2.3557961457131,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Tolbiac",
                            Latitude = 48.826159453911,
                            Longitude = 2.3570194661891,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Maison Blanche",
                            Latitude = 48.822878775063,
                            Longitude = 2.3580798942909,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Porte d'Italie",
                            Latitude = 48.818717025115,
                            Longitude = 2.3605008328054,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Porte de Choisy",
                            Latitude = 48.819713907179,
                            Longitude = 2.3640808202094,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Porte d'Ivry",
                            Latitude = 48.821357362308,
                            Longitude = 2.3693082372232,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Pierre et Marie Curie",
                            Latitude = 48.8159171816,
                            Longitude = 2.3778788164839,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Mairie d'Ivry",
                            Latitude = 48.81121453549,
                            Longitude = 2.3835089287327,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Le Kremlin-Bicetre",
                            Latitude = 48.810385125129,
                            Longitude = 2.3618306830911,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Villejuif-Leo Lagrange",
                            Latitude = 48.803769663283,
                            Longitude = 2.363909306389,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Villejuif-Paul Vaillant Couturier (Hopital Paul Brousse)",
                            Latitude = 48.795994132393,
                            Longitude = 2.3682314519157,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Villejuif-Louis Aragon",
                            Latitude = 48.78663801112,
                            Longitude = 2.3671105273816,
                            LineID = "7"
                        },
                        new Station
                        {
                            Name = "Pre-Saint-Gervais",
                            Latitude = 48.880159932112,
                            Longitude = 2.3985866218698,
                            LineID = "7b"
                        },
                        new Station
                        {
                            Name = "Danube",
                            Latitude = 48.881951018178,
                            Longitude = 2.3932606758574,
                            LineID = "7b"
                        },
                        new Station
                        {
                            Name = "Botzaris",
                            Latitude = 48.879607088933,
                            Longitude = 2.3894155696532,
                            LineID = "7b"
                        },
                        new Station
                        {
                            Name = "Buttes-Chaumont",
                            Latitude = 48.877803956008,
                            Longitude = 2.381211099736,
                            LineID = "7b"
                        },
                        new Station
                        {
                            Name = "Bolivar",
                            Latitude = 48.880790122828,
                            Longitude = 2.3741551266626,
                            LineID = "7b"
                        },
                        new Station
                        {
                            Name = "Jaures",
                            Latitude = 48.882876216213,
                            Longitude = 2.3705863361654,
                            LineID = "7b"
                        },
                        new Station
                        {
                            Name = "Louis Blanc",
                            Latitude = 48.881493428859,
                            Longitude = 2.3657752423496,
                            LineID = "7b"
                        },
                        new Station
                        {
                            Name = "Place des Fetes",
                            Latitude = 48.876729468907,
                            Longitude = 2.3931460317678,
                            LineID = "7b"
                        },
                        new Station
                        {
                            Name = "Balard",
                            Latitude = 48.83648174358,
                            Longitude = 2.2772677810199,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Lourmel",
                            Latitude = 48.83866812903,
                            Longitude = 2.2822484883841,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Boucicaut",
                            Latitude = 48.841025355322,
                            Longitude = 2.2879238673309,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Felix Faure",
                            Latitude = 48.842824567674,
                            Longitude = 2.2922249662205,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Commerce",
                            Latitude = 48.844613671994,
                            Longitude = 2.2938029801691,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "La Motte-Picquet-Grenelle",
                            Latitude = 48.848821266686,
                            Longitude = 2.2979529640252,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Ecole Militaire",
                            Latitude = 48.854054184702,
                            Longitude = 2.3053443513132,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "La Tour-Maubourg",
                            Latitude = 48.85722786065,
                            Longitude = 2.3097962258274,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Invalides",
                            Latitude = 48.861093467621,
                            Longitude = 2.3146433553464,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Concorde",
                            Latitude = 48.86548939089,
                            Longitude = 2.3214117892138,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Madeleine",
                            Latitude = 48.869794715218,
                            Longitude = 2.3246120120223,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Opera",
                            Latitude = 48.872095955632,
                            Longitude = 2.3305924621304,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Richelieu-Drouot",
                            Latitude = 48.87209612379,
                            Longitude = 2.3393255558564,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Grands Boulevards",
                            Latitude = 48.871511817078,
                            Longitude = 2.3432083775449,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Bonne Nouvelle",
                            Latitude = 48.870495832331,
                            Longitude = 2.3488621174406,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Strasbourg-Saint-Denis",
                            Latitude = 48.869227930988,
                            Longitude = 2.3545291753858,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Republique",
                            Latitude = 48.867410828835,
                            Longitude = 2.363587825558,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Filles du Calvaire",
                            Latitude = 48.863078176355,
                            Longitude = 2.3667458835847,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Saint-Sebastien-Froissart",
                            Latitude = 48.860974997187,
                            Longitude = 2.3672622950229,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Chemin Vert",
                            Latitude = 48.857586544465,
                            Longitude = 2.3680366949484,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Bastille",
                            Latitude = 48.852975674654,
                            Longitude = 2.3692188244433,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Ledru-Rollin",
                            Latitude = 48.851194165364,
                            Longitude = 2.3759317370129,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Faidherbe-Chaligny",
                            Latitude = 48.849582143385,
                            Longitude = 2.3849322048038,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Reuilly-Diderot",
                            Latitude = 48.847522955734,
                            Longitude = 2.3874904434685,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Montgallet",
                            Latitude = 48.844178422257,
                            Longitude = 2.3902105731037,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Daumesnil (Felix Eboue)",
                            Latitude = 48.839682140209,
                            Longitude = 2.3955841703467,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Michel Bizot",
                            Latitude = 48.836991037653,
                            Longitude = 2.40291960687,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Porte Doree",
                            Latitude = 48.835173857133,
                            Longitude = 2.4059124929479,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Porte de Charenton",
                            Latitude = 48.832660346482,
                            Longitude = 2.4004636384498,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Liberte",
                            Latitude = 48.825637111728,
                            Longitude = 2.4074108054261,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Charenton-Ecoles",
                            Latitude = 48.821489819146,
                            Longitude = 2.4138567623311,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Ecole Veterinaire de Maisons-Alfort",
                            Latitude = 48.81507632013,
                            Longitude = 2.4216317667307,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Maisons-Alfort-Stade",
                            Latitude = 48.808225347352,
                            Longitude = 2.4362758210511,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Maisons-Alfort-Les Juilliottes",
                            Latitude = 48.802500441831,
                            Longitude = 2.4461836185595,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Creteil-L'Echat (Hopital Henri Mondor)",
                            Latitude = 48.796601297578,
                            Longitude = 2.4495315243761,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Creteil-Universite",
                            Latitude = 48.78972431608,
                            Longitude = 2.4508361063907,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Creteil-Prefecture (Hotel de Ville)",
                            Latitude = 48.779757257845,
                            Longitude = 2.4593142910788,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Pointe du Lac",
                            Latitude = 48.768768635742,
                            Longitude = 2.4643193989483,
                            LineID = "8"
                        },
                        new Station
                        {
                            Name = "Pont de Sevres",
                            Latitude = 48.829690338023,
                            Longitude = 2.2305284341923,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Billancourt",
                            Latitude = 48.832087644283,
                            Longitude = 2.2381607768755,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Marcel Sembat",
                            Latitude = 48.83380858698,
                            Longitude = 2.2434806144174,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Porte de Saint-Cloud",
                            Latitude = 48.837565334474,
                            Longitude = 2.2555912744479,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Exelmans",
                            Latitude = 48.842906978536,
                            Longitude = 2.2601443978809,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Michel-Ange-Molitor",
                            Latitude = 48.845056129032,
                            Longitude = 2.2619114232798,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Michel-Ange-Auteuil",
                            Latitude = 48.847933946139,
                            Longitude = 2.2648350771737,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Jasmin",
                            Latitude = 48.852438519223,
                            Longitude = 2.267933923001,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Ranelagh",
                            Latitude = 48.855504403002,
                            Longitude = 2.2699591782558,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "La Muette",
                            Latitude = 48.858095049683,
                            Longitude = 2.2740964481106,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Rue de la Pompe (Avenue Georges Mandel)",
                            Latitude = 48.864253384403,
                            Longitude = 2.2779167620288,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Trocadero",
                            Latitude = 48.864419757097,
                            Longitude = 2.2880105904162,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Iena",
                            Latitude = 48.864656030025,
                            Longitude = 2.2947669865321,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Alma-Marceau",
                            Latitude = 48.864298671047,
                            Longitude = 2.3012514104499,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Franklin-Roosevelt",
                            Latitude = 48.868812631861,
                            Longitude = 2.3099263244705,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Saint-Philippe du Roule",
                            Latitude = 48.872470665794,
                            Longitude = 2.3107691012304,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Miromesnil",
                            Latitude = 48.873460325511,
                            Longitude = 2.3160412889151,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Saint-Augustin",
                            Latitude = 48.874350712606,
                            Longitude = 2.3200329804927,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Havre-Caumartin",
                            Latitude = 48.873425976535,
                            Longitude = 2.3289709732966,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Chaussee d'Antin (La Fayette)",
                            Latitude = 48.872985824665,
                            Longitude = 2.3334262240528,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Richelieu-Drouot",
                            Latitude = 48.87209612379,
                            Longitude = 2.3393255558564,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Grands Boulevards",
                            Latitude = 48.871511817078,
                            Longitude = 2.3432083775449,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Bonne Nouvelle",
                            Latitude = 48.870495832331,
                            Longitude = 2.3488621174406,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Strasbourg-Saint-Denis",
                            Latitude = 48.869227930988,
                            Longitude = 2.3545291753858,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Republique",
                            Latitude = 48.867410828835,
                            Longitude = 2.363587825558,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Oberkampf",
                            Latitude = 48.864965303262,
                            Longitude = 2.3676324062988,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Saint-Ambroise",
                            Latitude = 48.862248378426,
                            Longitude = 2.376934357531,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Voltaire (Leon Blum)",
                            Latitude = 48.85766372576,
                            Longitude = 2.3800362967955,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Charonne",
                            Latitude = 48.854642047445,
                            Longitude = 2.3850321933348,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Rue des Boulets",
                            Latitude = 48.852222713184,
                            Longitude = 2.3891156509272,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Nation",
                            Latitude = 48.848111231576,
                            Longitude = 2.3980040127977,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Buzenval",
                            Latitude = 48.851767474505,
                            Longitude = 2.4011814838726,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Maraichers",
                            Latitude = 48.913982562739,
                            Longitude = 2.3628888344747,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Porte de Montreuil",
                            Latitude = 48.853990890307,
                            Longitude = 2.410676960542,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Robespierre",
                            Latitude = 48.855680808197,
                            Longitude = 2.423659085483,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Croix-de-Chavaux (Jacques Duclos)",
                            Latitude = 48.857999073258,
                            Longitude = 2.4358668956747,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Mairie de Montreuil",
                            Latitude = 48.862424401025,
                            Longitude = 2.4422638608899,
                            LineID = "9"
                        },
                        new Station
                        {
                            Name = "Boulogne Pont de Saint-Cloud",
                            Latitude = 48.840680163122,
                            Longitude = 2.2283136617243,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Boulogne-Jean-Jaures",
                            Latitude = 48.84228014353,
                            Longitude = 2.2388629753673,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Porte d'Auteuil",
                            Latitude = 48.847390152722,
                            Longitude = 2.2577137851809,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Michel-Ange-Molitor",
                            Latitude = 48.845056129032,
                            Longitude = 2.2619114232798,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Chardon-Lagache",
                            Latitude = 48.845104139567,
                            Longitude = 2.2669360590323,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Mirabeau",
                            Latitude = 48.847084858905,
                            Longitude = 2.273074914922,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Javel-Andre-Citroen",
                            Latitude = 48.845963880484,
                            Longitude = 2.2778151263538,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Charles Michels",
                            Latitude = 48.846362975501,
                            Longitude = 2.2856310658829,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Avenue Emile-Zola",
                            Latitude = 48.84685215195,
                            Longitude = 2.2954488279345,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "La Motte-Picquet-Grenelle",
                            Latitude = 48.848821266686,
                            Longitude = 2.2979529640252,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Segur",
                            Latitude = 48.846864702069,
                            Longitude = 2.3072688475789,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Duroc",
                            Latitude = 48.846848768896,
                            Longitude = 2.3169373108341,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Vaneau",
                            Latitude = 48.84870084962,
                            Longitude = 2.3212398819386,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Sevres-Babylone",
                            Latitude = 48.85191000057,
                            Longitude = 2.3268362464345,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Mabillon",
                            Latitude = 48.852845133654,
                            Longitude = 2.3351437185161,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Odeon",
                            Latitude = 48.852314881195,
                            Longitude = 2.3388617203363,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Cluny-La Sorbonne",
                            Latitude = 48.850795755704,
                            Longitude = 2.3450308883652,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Maubert-Mutualite",
                            Latitude = 48.849716940164,
                            Longitude = 2.3489255584919,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Cardinal-Lemoine",
                            Latitude = 48.84670586906,
                            Longitude = 2.3513351789726,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Jussieu",
                            Latitude = 48.845761757311,
                            Longitude = 2.3545485949067,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Gare d'Austerlitz",
                            Latitude = 48.843863634268,
                            Longitude = 2.3640388418743,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Eglise d'Auteuil",
                            Latitude = 48.847532242117,
                            Longitude = 2.2694792821877,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Michel-Ange-Auteuil",
                            Latitude = 48.847933946139,
                            Longitude = 2.2648350771737,
                            LineID = "10"
                        },
                        new Station
                        {
                            Name = "Mairie des Lilas",
                            Latitude = 48.880051061773,
                            Longitude = 2.4156602060642,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Porte des Lilas",
                            Latitude = 48.876938223509,
                            Longitude = 2.4063765669298,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Telegraphe",
                            Latitude = 48.875522449246,
                            Longitude = 2.398676511145,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Place des Fetes",
                            Latitude = 48.876729468907,
                            Longitude = 2.3931460317678,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Jourdain",
                            Latitude = 48.875248294625,
                            Longitude = 2.3893294341526,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Pyrenees",
                            Latitude = 48.873821172337,
                            Longitude = 2.3848863721979,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Belleville",
                            Latitude = 48.871945797975,
                            Longitude = 2.3767510413738,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Goncourt (Hopital Saint-Louis)",
                            Latitude = 48.870015355247,
                            Longitude = 2.3707687990215,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Republique",
                            Latitude = 48.867410828835,
                            Longitude = 2.363587825558,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Arts-et-Metiers",
                            Latitude = 48.865381176047,
                            Longitude = 2.3556449312069,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Rambuteau",
                            Latitude = 48.861193395642,
                            Longitude = 2.3532869598707,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Hotel de Ville",
                            Latitude = 48.85735592717,
                            Longitude = 2.3520735668587,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Chatelet",
                            Latitude = 48.858389963549,
                            Longitude = 2.3474837299933,
                            LineID = "11"
                        },
                        new Station
                        {
                            Name = "Mairie d'Issy",
                            Latitude = 48.824346526018,
                            Longitude = 2.2735658296006,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Corentin-Celton",
                            Latitude = 48.826829887394,
                            Longitude = 2.2789668615743,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Porte de Versailles",
                            Latitude = 48.833187643241,
                            Longitude = 2.2866243784868,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Convention",
                            Latitude = 48.837136949563,
                            Longitude = 2.2963960901556,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Vaugirard (Adolphe Cherioux)",
                            Latitude = 48.83943928124,
                            Longitude = 2.3010780424739,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Volontaires",
                            Latitude = 48.841418442678,
                            Longitude = 2.3079936493867,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Pasteur",
                            Latitude = 48.901846740843,
                            Longitude = 2.2992623155968,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Falguiere",
                            Latitude = 48.844323383002,
                            Longitude = 2.3175646761806,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Montparnasse-Bienvenue",
                            Latitude = 48.842077020187,
                            Longitude = 2.3210104495551,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Notre-Dame des Champs",
                            Latitude = 48.84462130823,
                            Longitude = 2.3289347211572,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Rennes",
                            Latitude = 48.848198268825,
                            Longitude = 2.3280217486281,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Sevres-Babylone",
                            Latitude = 48.85191000057,
                            Longitude = 2.3268362464345,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Rue du Bac",
                            Latitude = 48.855891337816,
                            Longitude = 2.3257049938993,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Solferino",
                            Latitude = 48.858533359508,
                            Longitude = 2.3230892487872,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Assemblee Nationale",
                            Latitude = 48.861453904295,
                            Longitude = 2.3203096905074,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Concorde",
                            Latitude = 48.86548939089,
                            Longitude = 2.3214117892138,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Madeleine",
                            Latitude = 48.869794715218,
                            Longitude = 2.3246120120223,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Saint-Lazare",
                            Latitude = 48.875420977789,
                            Longitude = 2.3266952720717,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Trinite-d'Estienne d'Orves",
                            Latitude = 48.876329037439,
                            Longitude = 2.3318045685106,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Notre-Dame de Lorette",
                            Latitude = 48.876050554237,
                            Longitude = 2.3379086920376,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Saint-Georges",
                            Latitude = 48.878593955236,
                            Longitude = 2.337826968917,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Pigalle",
                            Latitude = 48.882027089626,
                            Longitude = 2.3372138017479,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Abbesses",
                            Latitude = 48.884354772274,
                            Longitude = 2.3389444789054,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Lamarck-Caulaincourt",
                            Latitude = 48.889756058044,
                            Longitude = 2.3403075364645,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Jules Joffrin",
                            Latitude = 48.89249697693,
                            Longitude = 2.3443284105515,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Marcadet-Poissonniers",
                            Latitude = 48.891543930631,
                            Longitude = 2.3493711153819,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Marx-Dormoy",
                            Latitude = 48.890374081221,
                            Longitude = 2.3597970086706,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Porte de la Chapelle",
                            Latitude = 48.897959343241,
                            Longitude = 2.3592550695797,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Front Populaire",
                            Latitude = 48.906666587875,
                            Longitude = 2.3652301358544,
                            LineID = "12"
                        },
                        new Station
                        {
                            Name = "Chatillon Montrouge",
                            Latitude = 48.810283363511,
                            Longitude = 2.301288870976,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Malakoff-Rue Etienne Dolet",
                            Latitude = 48.814704060567,
                            Longitude = 2.2972847301706,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Malakoff-Plateau de Vanves",
                            Latitude = 48.822442694,
                            Longitude = 2.2979321053287,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Porte de Vanves",
                            Latitude = 48.827513932462,
                            Longitude = 2.3052653830764,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Plaisance",
                            Latitude = 48.831758093788,
                            Longitude = 2.3138665498482,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Pernety",
                            Latitude = 48.833933819811,
                            Longitude = 2.3179089721633,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Gaite",
                            Latitude = 48.838814669136,
                            Longitude = 2.3219917819578,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Montparnasse-Bienvenue",
                            Latitude = 48.842077020187,
                            Longitude = 2.3210104495551,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Duroc",
                            Latitude = 48.846848768896,
                            Longitude = 2.3169373108341,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Saint-Francois-Xavier",
                            Latitude = 48.850982559823,
                            Longitude = 2.3144298646003,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Varenne",
                            Latitude = 48.856393069198,
                            Longitude = 2.3147543648103,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Invalides",
                            Latitude = 48.861093467621,
                            Longitude = 2.3146433553464,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Champs-Elysees-Clemenceau",
                            Latitude = 48.867744026069,
                            Longitude = 2.3141227803741,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Miromesnil",
                            Latitude = 48.873460325511,
                            Longitude = 2.3160412889151,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Saint-Lazare",
                            Latitude = 48.875420977789,
                            Longitude = 2.3266952720717,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Liege",
                            Latitude = 48.879537166381,
                            Longitude = 2.326857947273,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Place de Clichy",
                            Latitude = 48.883203999877,
                            Longitude = 2.3272660246411,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "La Fourche",
                            Latitude = 48.887436842529,
                            Longitude = 2.3257252220174,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Guy-Moquet",
                            Latitude = 48.971254435036,
                            Longitude = 2.3923472104512,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Porte de Saint-Ouen",
                            Latitude = 48.897511732771,
                            Longitude = 2.3290216472122,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Garibaldi",
                            Latitude = 48.906382164226,
                            Longitude = 2.3319104734589,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Mairie de Saint-Ouen",
                            Latitude = 48.911621680384,
                            Longitude = 2.3337369648421,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Carrefour-Pleyel",
                            Latitude = 48.919943505083,
                            Longitude = 2.3439094197859,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Saint-Denis - Porte de Paris",
                            Latitude = 48.929926665271,
                            Longitude = 2.3561861491889,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Basilique de Saint-Denis",
                            Latitude = 48.937618354746,
                            Longitude = 2.3620002027025,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Saint-Denis-Universite",
                            Latitude = 48.946110872487,
                            Longitude = 2.3620451929906,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Brochant",
                            Latitude = 48.890626633024,
                            Longitude = 2.3201911212753,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Porte de Clichy",
                            Latitude = 48.894436060298,
                            Longitude = 2.3135656654652,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Mairie de Clichy",
                            Latitude = 48.90400543243,
                            Longitude = 2.3053681208669,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Gabriel-Peri",
                            Latitude = 48.810049376089,
                            Longitude = 2.4368644399878,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Les Agnettes",
                            Latitude = 48.922916331509,
                            Longitude = 2.2859638965766,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Asnieres-Gennevilliers Les Courtilles",
                            Latitude = 48.930293622871,
                            Longitude = 2.2837606331952,
                            LineID = "13"
                        },
                        new Station
                        {
                            Name = "Saint-Lazare",
                            Latitude = 48.875420977789,
                            Longitude = 2.3266952720717,
                            LineID = "14"
                        },
                        new Station
                        {
                            Name = "Madeleine",
                            Latitude = 48.869794715218,
                            Longitude = 2.3246120120223,
                            LineID = "14"
                        },
                        new Station
                        {
                            Name = "Pyramides",
                            Latitude = 48.866496987039,
                            Longitude = 2.3340942152591,
                            LineID = "14"
                        },
                        new Station
                        {
                            Name = "Chatelet",
                            Latitude = 48.858389963549,
                            Longitude = 2.3474837299933,
                            LineID = "14"
                        },
                        new Station
                        {
                            Name = "Gare de Lyon",
                            Latitude = 48.845559787083,
                            Longitude = 2.3734492049632,
                            LineID = "14"
                        },
                        new Station
                        {
                            Name = "Bercy",
                            Latitude = 48.840542782965,
                            Longitude = 2.3794094631231,
                            LineID = "14"
                        },
                        new Station
                        {
                            Name = "Cour Saint-Emilion",
                            Latitude = 48.833313715578,
                            Longitude = 2.3872997043835,
                            LineID = "14"
                        },
                        new Station
                        {
                            Name = "Bibliotheque-Francois Mitterrand",
                            Latitude = 48.829830695271,
                            Longitude = 2.3761200093448,
                            LineID = "14"
                        },
                        new Station
                        {
                            Name = "Olympiades",
                            Latitude = 48.826948281961,
                            Longitude = 2.3670384333876,
                            LineID = "14"
                        }

                    );
                }
                context.SaveChanges();
            }
        }
    }
}