using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    class DateBase
    {
        //List<Place> places = new List<Place>();

        public List<Place> GetBase(List<Place> places)
        {

            places.Add(new Place()
            {
                ID = 201,
                Name = "Шумихинские скалы",
                Description = "",
                GeoLat = 58.73436,
                GeoLng = 57.71879,
                AreaName = "Пермский край",
                AreaID = 2,
            }) ;
            places.Add(new Place()
            {
                ID = 202,
                Name = "Каменный город",
                Description = "",
                GeoLat = 58.72222,
                GeoLng = 57.63305,
                AreaName = "Пермский край",
                AreaID = 2,
            }) ;
            places.Add(new Place()
            {
                ID = 203,
                Name = "Усьвинские Столбы",
                Description = "",
                GeoLat = 58.65166,
                GeoLng = 57.57083,
                AreaName = "Пермский край",
                AreaID = 2,
            });
            places.Add(new Place()
            {
                ID = 204,
                Name = "Адово озеро",
                Description = "",
                GeoLat = 60.22014,
                GeoLng = 52.96207,
                AreaName = "Пермский край",
                AreaID = 2,
            });
            places.Add(new Place()
            {
                ID = 205,
                Name = "Гора Ослянка",
                Description = "",
                GeoLat = 59.16277,
                GeoLng = 58.55194,
                AreaName = "Пермский край",
                AreaID = 2,
            });
            places.Add(new Place()
            {
                ID = 206,
                Name = "Камень Ветлан",
                Description = "",
                GeoLat = 60.47583,
                GeoLng = 57.09583,
                AreaName = "Пермский край",
                AreaID = 2,
            });
            places.Add(new Place()
            {
                ID = 207,
                Name = "Полюдов камень",
                Description = "",
                GeoLat = 60.48444,
                GeoLng = 57.00277,
                AreaName = "Пермский край",
                AreaID = 2,
            });
            places.Add(new Place()
            {
                ID = 208,
                Name = "Помяненный камень",
                Description = "",
                GeoLat = 60.33489,
                GeoLng = 57.61206,
                AreaName = "Пермский край",
                AreaID = 2,
            });
            places.Add(new Place()
            {
                ID = 209,
                Name = "Жигаланские водопады и Хребет Кваркуш",
                Description = "",
                GeoLat = 60.16694,
                GeoLng = 58.8025,
                AreaName = "Пермский край",
                AreaID = 2,
            });
            places.Add(new Place()
            {
                ID = 210,
                Name = "Заповедник Басеги",
                Description = "",
                GeoLat = 58.85667,
                GeoLng = 58.42852,
                AreaName = "Пермский край",
                AreaID = 2,
            });
            places.Add(new Place()
            {
                ID = 211,
                Name = "Вишерский заповедник",
                Description = "",
                GeoLat = 61.483,
                GeoLng = 59.21699,
                AreaName = "Пермский край",
                AreaID = 2,
            });
            places.Add(new Place()
            {
                ID = 301,
                Name = "Гора Азов",
                Description = "",
                GeoLat = 56.47472,
                GeoLng = 60.085,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 302,
                Name = "Алапаевск",
                Description = "",
                GeoLat = 57.84834,
                GeoLng = 61.68803,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 303,
                Name = "Асбестовский карьер",
                Description = "",
                GeoLat = 56.99805,
                GeoLng = 61.49111,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 304,
                Name = "Березовский рудник",
                Description = "",
                GeoLat = 56.93176,
                GeoLng = 60.78571,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 305,
                Name = "Верх-Нейвинский",
                Description = "",
                GeoLat = 57.26555,
                GeoLng = 60.13166,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 306,
                Name = "Верхотурье",
                Description = "",
                GeoLat = 58.86415,
                GeoLng = 60.7533,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 307,
                Name = "Гора Качканар",
                Description = "",
                GeoLat = 58.77,
                GeoLng = 59.38305,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 308,
                Name = "Дегтярск",
                Description = "",
                GeoLat = 56.698,
                GeoLng = 60.10207,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 309,
                Name = "Дидинский тоннель",
                Description = "",
                GeoLat = 56.81777,
                GeoLng = 59.71583,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 310,
                Name = "Конжаковский камень",
                Description = "",
                GeoLat = 59.626,
                GeoLng = 59.13416,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 311,
                Name = "Коуровская астрономическая обсерватория",
                Description = "",
                GeoLat = 57.03696,
                GeoLng = 59.54752,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 312,
                Name = "Перевал Дятлова",
                Description = "",
                GeoLat = 61.75472,
                GeoLng = 59.46277,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 313,
                Name = "Троицко-Байновское месторождение огнеупорных глин",
                Description = "",
                GeoLat = 56.62368,
                GeoLng = 62.08336,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 314,
                Name = "Хребет Чистоп",
                Description = "",
                GeoLat = 61.49255,
                GeoLng = 59.76699,
                AreaName = "Свердловская область",
                AreaID = 3,
            });
            places.Add(new Place()
            {
                ID = 401,
                Name = "Александровская сопка",
                Description = "",
                GeoLat = 55.13055,
                GeoLng = 59.80694,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 402,
                Name = "Аргазинское водохранилище",
                Description = "",
                GeoLat = 55.38888,
                GeoLng = 60.38888,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 403,
                Name = "Каолиновый карьер (Кыштым)",
                Description = "",
                GeoLat = 55.68128,
                GeoLng = 60.59991,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 404,
                Name = "Беликуль (Богородицкая церковь)",
                Description = "",
                GeoLat = 55.70162,
                GeoLng = 62.43968,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 405,
                Name = "Златоуст",
                Description = "",
                GeoLat = 55.15587,
                GeoLng = 59.68588,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 406,
                Name = "Таганай",
                Description = "",
                GeoLat = 55.16124,
                GeoLng = 59.78059,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 407,
                Name = "Озеро Аракуль",
                Description = "",
                GeoLat = 55.99383,
                GeoLng = 60.56714,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 408,
                Name = "Озеро Большие Аллаки",
                Description = "",
                GeoLat = 55.95907,
                GeoLng = 60.92053,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 409,
                Name = "Озеро Большой Сунукуль",
                Description = "",
                GeoLat = 55.0675,
                GeoLng = 60.39277,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 410,
                Name = "Озеро Иткуль",
                Description = "",
                GeoLat = 56.14207,
                GeoLng = 60.51647,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 411,
                Name = "Озеро Тургояк",
                Description = "",
                GeoLat = 55.16658,
                GeoLng = 60.06059,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 412,
                Name = "Черемшанские Карьеры",
                Description = "",
                GeoLat = 56.12555,
                GeoLng = 60.30638,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 413,
                Name = "Урочище Пороги",
                Description = "",
                GeoLat = 55.26722,
                GeoLng = 59.14055,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 414,
                Name = "Хребет Нургуш",
                Description = "",
                GeoLat = 54.82,
                GeoLng = 59.14305,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 415,
                Name = "Хребет Уреньга",
                Description = "",
                GeoLat = 54.88361,
                GeoLng = 59.35055,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 416,
                Name = "Хребет Ишкуль",
                Description = "",
                GeoLat = 55.25416,
                GeoLng = 60.20444,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 417,
                Name = "Большие и Малые Притесы на реке Ай",
                Description = "",
                GeoLat = 55.14591,
                GeoLng = 58.71007,
                AreaName = "Челябинская область",
                AreaID = 4,
            });
            places.Add(new Place()
            {
                ID = 501,
                Name = "Айгир",
                Description = "",
                GeoLat = 54.12416,
                GeoLng = 57.69861,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 502,
                Name = "Водопад Гадельша",
                Description = "",
                GeoLat = 52.75735,
                GeoLng = 58.37241,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 503,
                Name = "Водопад Куперля и карстовый мост",
                Description = "",
                GeoLat = 53.1525,
                GeoLng = 56.63777,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 504,
                Name = "Хребет Иремель",
                Description = "",
                GeoLat = 54.51972,
                GeoLng = 58.84305,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 505,
                Name = "Гора Сусак-тау",
                Description = "",
                GeoLat = 53.98694,
                GeoLng = 55.04861,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 506,
                Name = "Мурадымовское ущелье",
                Description = "",
                GeoLat = 52.6125,
                GeoLng = 56.51027,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 507,
                Name = "Нугушское водохранилище",
                Description = "",
                GeoLat = 53.05138,
                GeoLng = 56.44666,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 508,
                Name = "Озеро Аушкуль и гора Ауштау",
                Description = "",
                GeoLat = 54.71944,
                GeoLng = 59.70555,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 509,
                Name = "Павловское водохранилище",
                Description = "",
                GeoLat = 55.41111,
                GeoLng = 56.5425,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 510,
                Name = "Сибайский карьер",
                Description = "",
                GeoLat = 52.72055,
                GeoLng = 58.66638,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 511,
                Name = "Ямантау",
                Description = "",
                GeoLat = 54.255,
                GeoLng = 58.10199,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 512,
                Name = "Хребет Инзерские зубчатки",
                Description = "",
                GeoLat = 54.24864,
                GeoLng = 58.34935,
                AreaName = "Республика Башкортостан",
                AreaID = 5,
            });
            places.Add(new Place()
            {
                ID = 101,
                Name = "Гора Народная",
                Description = "",
                GeoLat = 65.03333,
                GeoLng = 60.11666,
                AreaName = "Республика Коми",
                AreaID = 1,
            });
            places.Add(new Place()
            {
                ID = 102,
                Name = "Гора Манарага",
                Description = "",
                GeoLat = 65.04777,
                GeoLng = 59.76277,
                AreaName = "Республика Коми",
                AreaID = 1,
            });
            places.Add(new Place()
            {
                ID = 103,
                Name = "Город-призрак Хальмер-Ю",
                Description = "",
                GeoLat = 67.94444,
                GeoLng = 64.73611,
                AreaName = "Республика Коми",
                AreaID = 1,
            });
            places.Add(new Place()
            {
                ID = 104,
                Name = "Граддор",
                Description = "",
                GeoLat = 61.5552,
                GeoLng = 50.78572,
                AreaName = "Республика Коми",
                AreaID = 1,
            });
            places.Add(new Place()
            {
                ID = 105,
                Name = "Село Зеленец",
                Description = "",
                GeoLat = 61.88777,
                GeoLng = 50.75194,
                AreaName = "Республика Коми",
                AreaID = 1,
            });
            places.Add(new Place()
            {
                ID = 106,
                Name = "Княжпогост и Емва",
                Description = "",
                GeoLat = 62.6,
                GeoLng = 50.84444,
                AreaName = "Республика Коми",
                AreaID = 1,
            });
            places.Add(new Place()
            {
                ID = 107,
                Name = "Югыд Ва Национальный Парк",
                Description = "",
                GeoLat = 63.84727,
                GeoLng = 57.30657,
                AreaName = "Республика Коми",
                AreaID = 1,
            });
            places.Add(new Place()
            {
                ID = 108,
                Name = "Столбы выветривания Мань-Пупу-Нер",
                Description = "",
                GeoLat = 62.25777,
                GeoLng = 59.29805,
                AreaName = "Республика Коми",
                AreaID = 1,
            });
            places.Add(new Place()
            {
                ID = 109,
                Name = "Ульяновский Троице-Стефановский монастырь",
                Description = "",
                GeoLat = 61.83055,
                GeoLng = 53.55555,
                AreaName = "Республика Коми",
                AreaID = 1,
            });
            places.Add(new Place()
            {
                ID = 601,
                Name = "Бузулукский бор",
                Description = "",
                GeoLat = 53.02903,
                GeoLng = 52.08903,
                AreaName = "Оренбургская область",
                AreaID = 6,
            });
            places.Add(new Place()
            {
                ID = 602,
                Name = "Орская яшма",
                Description = "",
                GeoLat = 51.15416,
                GeoLng = 58.65277,
                AreaName = "Оренбургская область",
                AreaID = 6,
            });
            places.Add(new Place()
            {
                ID = 603,
                Name = "Губерлинские горы",
                Description = "",
                GeoLat = 51.46111,
                GeoLng = 58.30833,
                AreaName = "Оренбургская область",
                AreaID = 6,
            });
            places.Add(new Place()
            {
                ID = 604,
                Name = "Кзыладырское карстровое поле",
                Description = "",
                GeoLat = 51.18055,
                GeoLng = 56.92722,
                AreaName = "Оренбургская область",
                AreaID = 6,
            });
            places.Add(new Place()
            {
                ID = 605,
                Name = "Красная круча",
                Description = "",
                GeoLat = 51.47638,
                GeoLng = 54.20111,
                AreaName = "Оренбургская область",
                AreaID = 6,
            });
            places.Add(new Place()
            {
                ID = 606,
                Name = "Город Кувандык",
                Description = "",
                GeoLat = 51.47638,
                GeoLng = 57.35194,
                AreaName = "Оренбургская область",
                AreaID = 6,
            });
            places.Add(new Place()
            {
                ID = 607,
                Name = "Общий Сырт",
                Description = "",
                GeoLat = 52.295218,
                GeoLng = 52.180433,
                AreaName = "Оренбургская область",
                AreaID = 6,
            });
            places.Add(new Place()
            {
                ID = 608,
                Name = "Оренбургский государственный природный заповедник",
                Description = "",
                GeoLat = 51.104443,
                GeoLng = 57.662523,
                AreaName = "Оренбургская область",
                AreaID = 6,
            });
            places.Add(new Place()
            {
                ID = 609,
                Name = "Хребет Шайтантау",
                Description = "",
                GeoLat = 51.93222,
                GeoLng = 57.91194,
                AreaName = "Оренбургская область",
                AreaID = 6,
            });
            return places;
        }

    }
}
