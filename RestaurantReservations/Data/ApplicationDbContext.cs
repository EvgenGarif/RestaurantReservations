using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantReservations.Model;
using System;



namespace RestaurantReservations.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Client> Clients { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<IdentityUserLogin<string>>();
            modelBuilder.Ignore<IdentityUserRole<string>>();
            modelBuilder.Ignore<IdentityUserClaim<string>>();
            modelBuilder.Ignore<IdentityUserToken<string>>();
            modelBuilder.Ignore<IdentityUser<string>>();

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant[]
                {
                new Restaurant { Id=1, NameRestaurant="Basilio", NumberOfTables=20
                , WorkingHours = "пн-сб 12.00–23.00", Picture = "/images/basilis1.jpg", Description = "Изначально Basilio, основанный регулярно работающим в Испании Дмитрием Модестовым, размещался в ЦДС, но потом переехал в ближе к АМЗ, оказавшись бок о бок с салоном фирмы Villeroy & Boch. Функционирует ресторан пять дней в неделю, причем в будни исключительно с 18:00 по 23:00, поэтому столики почти всегда лучше заказывать заранее. Меню небольшое, но сплошь пестрит блюдами премиум-класса, чьи цены в большинстве своем начинаются с 500 рублей — от паштета из кабана до карибского краба (2000 рублей). Тем, кто пришел в первый раз, лучше попробовать один из двух дегустационных сетов. "},
                new Restaurant { Id=2, NameRestaurant="Family Grill", NumberOfTables=15
                , WorkingHours = "пн-чт, вс 12.00–0.00, пт-сб 12.00–1.00", Picture = "/images/Family_grill.jpg", Description = "Это заведение холдинга Restostar очень старается подчеркнуть свою семейную направленность, местами скатываясь в совсем домашнее простодушие. В меню много разного мяса, но отдельным пунктом идет герефордская порода: ростбиф из нее обойдется в 520 р., а филе-миньон — в 650 р. Особенно залихватским выглядит название раздела «Под водочку и просто так», в котором, правда, можно найти мясные плато (670 р. за 450 г) и тартар из лосося (380 р. за 180 г)."},
                new Restaurant { Id=3, NameRestaurant="Шафран", NumberOfTables=9
                    , WorkingHours = "вт-вс 12.00–0.00", Picture = "/images/shafran.jpg", Description = "Это заведение находится в центре парка Гагарина. Летом тут работает открытая веранда с видом на водоем и фонтан, а также на отдыхающих, прогуливающихся по тропинкам или участвующих в экстремальном аттракционе с лазаньем по деревьям. Меню нестрого узбекское: манты, бишбармак, лагманы (в том числе с соусом песто), ризотто из ферганского риса, вьетнамский суп из телячьих хвостов, азербайджанский джиз-быз (на нескольких человек за 1800 рублей) и, конечно, восточные сладости."}
                });

            modelBuilder.Entity<Table>().HasData(
               new Table[]
               {
                new Table { Id=1, ItemTable=1, RestaurantId=1},
                new Table { Id=2, ItemTable=2, RestaurantId=1},
                new Table { Id=3, ItemTable=3, RestaurantId=1},
                new Table { Id=4, ItemTable=4, RestaurantId=1},
                new Table { Id=5, ItemTable=5, RestaurantId=1},
                new Table { Id=6, ItemTable=6, RestaurantId=1},
                new Table { Id=7, ItemTable=7, RestaurantId=1},
                new Table { Id=8, ItemTable=8, RestaurantId=1},
                new Table { Id=9, ItemTable=9, RestaurantId=1},
                new Table { Id=10, ItemTable=10, RestaurantId=1},
                new Table { Id=11, ItemTable=11, RestaurantId=1},
                new Table { Id=12, ItemTable=12, RestaurantId=1},
                new Table { Id=13, ItemTable=13, RestaurantId=1},
                new Table { Id=14, ItemTable=14, RestaurantId=1},
                new Table { Id=15, ItemTable=15, RestaurantId=1},
                new Table { Id=16, ItemTable=16, RestaurantId=1},
                new Table { Id=17, ItemTable=17, RestaurantId=1},
                new Table { Id=18, ItemTable=18, RestaurantId=1},
                new Table { Id=19, ItemTable=19, RestaurantId=1},
                new Table { Id=20, ItemTable=20, RestaurantId=1},
                new Table { Id=21, ItemTable=1, RestaurantId=2},
                new Table { Id=22, ItemTable=2, RestaurantId=2},
                new Table { Id=23, ItemTable=3, RestaurantId=2},
                new Table { Id=24, ItemTable=4, RestaurantId=2},
                new Table { Id=25, ItemTable=5, RestaurantId=2},
                new Table { Id=26, ItemTable=6, RestaurantId=2},
                new Table { Id=27, ItemTable=7, RestaurantId=2},
                new Table { Id=28, ItemTable=8, RestaurantId=2},
                new Table { Id=29, ItemTable=9, RestaurantId=2},
                new Table { Id=30, ItemTable=10, RestaurantId=2},
                new Table { Id=31, ItemTable=11, RestaurantId=2},
                new Table { Id=32, ItemTable=12, RestaurantId=2},
                new Table { Id=33, ItemTable=13, RestaurantId=2},
                new Table { Id=34, ItemTable=14, RestaurantId=2},
                new Table { Id=35, ItemTable=15, RestaurantId=2},
                new Table { Id=36, ItemTable=1, RestaurantId=3},
                new Table { Id=37, ItemTable=2, RestaurantId=3},
                new Table { Id=38, ItemTable=3, RestaurantId=3},
                new Table { Id=39, ItemTable=4, RestaurantId=3},
                new Table { Id=40, ItemTable=5, RestaurantId=3},
                new Table { Id=41, ItemTable=6, RestaurantId=3},
                new Table { Id=42, ItemTable=7, RestaurantId=3},
                new Table { Id=43, ItemTable=8, RestaurantId=3},
                new Table { Id=44, ItemTable=9, RestaurantId=3},
               });

            modelBuilder.Entity<Client>().HasData(
               new Client[]
               {
                new Client { Id=1, Name="Артем", LastName="Стрельников"
                , BookingTime = DateTime.Now, DurationOfBooking = DateTime.Now.AddHours(1), TableId = 15 },
                new Client { Id=2, Name="Артем", LastName="Стрельников"
                , BookingTime = DateTime.Now, DurationOfBooking = DateTime.Now.AddHours(1), TableId = 7 },
                new Client { Id=3, Name="Артем", LastName="Стрельников"
                , BookingTime = DateTime.Now, DurationOfBooking = DateTime.Now.AddHours(1), TableId = 28 },
                new Client { Id=4, Name="Артем", LastName="Стрельников"
                , BookingTime = DateTime.Now, DurationOfBooking = DateTime.Now.AddHours(1), TableId = 40 },
               });
        }
    }
}
