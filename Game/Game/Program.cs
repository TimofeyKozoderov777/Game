using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    class Survivor
    {
        private int _lvl;
        private string _Survivor;
        private double _Health_Survivor;
        private bool _Dodge;
        private static double count = 0;

        public int lvl
        {
            get => _lvl;
        }

        public Survivor(string survivor, double health, bool dodge)
        {
            _Survivor = survivor;
            _Health_Survivor = health;
            _Dodge = dodge;
            _lvl = lvl;
        }

        public string survivor
        {
            get { return _Survivor; }
            set { _Survivor = value; }
        }

        public double health
        {
            get => _Health_Survivor;
            set => _Health_Survivor = value;
        }
        private bool dodge
        {
            get => _Dodge;
            set => _Dodge = value;
        }

        internal class Enemy
        {
            private double _lvl;
            private string _Enemy;
            private double _Health_Enemy;
            private double _Damage_Enemy;
            private static double count = 0;

            public Enemy(string enemy, double health, double damage)
            {
                _lvl = count++;
                _Enemy = enemy;
                _Health_Enemy = health;
                _Damage_Enemy = damage;

            }

            public string enemy
            {
                get { return _Enemy; }
                set { _Enemy = value; }
            }

            public double health
            {
                get => _Health_Enemy;
                set => _Health_Enemy = value;
            }
            public double damage
            {
                get => _Damage_Enemy;
                set => _Damage_Enemy = value;
            }
            internal class Weapon
            {
                private string _Name;
                private double _Damage;
                private bool _Stun;

                public Weapon(string name, double damage, bool stun)
                {
                    _Name = name;
                    _Damage = damage;
                    _Stun = stun;

                }
                public string name
                {
                    get => _Name;
                    set => _Name = value;
                }

                public double damage
                {
                    get => _Damage;
                    set => _Damage = value;
                }
                public bool stun
                {
                    get => _Stun;
                    set => _Stun = value;
                }

                internal class Program
                {
                    static void Main(string[] args)
                    {
                        List<Survivor> survivors = new List<Survivor>(2)
    {
        new Survivor("Bruce Evans", 700, true),
        new Survivor("Felicia Fleming", 700, true),
    };
                        List<Enemy> enemies = new List<Enemy>()
        {
            new Enemy("Сosmopsycho", 1000, 50),
            new Enemy("Reik", 500, 30),
            new Enemy("Ksenomorf", 700, 70),
            new Enemy("Vindigo", 1500, 25),
            new Enemy("Chimera", 500, 100),
            new Enemy("Phantom", 200, 200),
        };

                        List<Weapon> inventory = new List<Weapon>()
        {
            new Weapon("Shotgun", 50, false),
        };
                        Console.WriteLine("ЭТО ИГРА В ЖАНРЕ КОСМИЧЕСКИХ ПРИКЛЮЧЕНИЕМ: АВРОРА\n\n");
                        Console.WriteLine("В ней вы должны попытать удачу, сражаясь с космическими вторженцами на корабле. Ваша победа зависит от силы попавшего вам на пути монстра и вашей ловкости в бою\n\n");
                        Console.WriteLine("Нажмите любую клавишу чтобы начать играть)");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Выберите персонажа:");
                        for (int i = 0; i < survivors.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ". " + survivors[i].survivor);
                        }
                        int choice = int.Parse(Console.ReadLine());
                        Survivor selectedSurvivor = survivors[choice - 1];

                        if (choice < 1 || choice > survivors.Count)
                        {
                            Console.WriteLine("Неправильный выбор. Попробуйте ещё раз.");
                        }
                        else
                        {
                            Console.WriteLine("Вы выбрали " + selectedSurvivor.survivor + "!");
                        }

                        switch (selectedSurvivor.survivor)
                        {
                            case "Bruce Evans":
                                Console.WriteLine("Эванс- капитан космического корабля Аврора. Он профессионал в области космических путешествий, опытный пилот и стратег. Сильный духом, смелый и решительный, он готов сражаться за своих людей и преодолевать любые препятствия на пути к успеху. Во время рейса на Авроре он взял на себя ответственность за спасение всего экипажа и противостоял неизвестным чудовищам, которые напали на корабль. Его отвага и решительность помогут ему преодолеть любые испытания и найти путь к спасению.");
                                Console.WriteLine("Для продолжения нажмите Enter" + "\n");
                                Console.ReadKey();
                                Console.WriteLine("Космический корабль Аврора неожиданно потерял управление после прохождения через область сильных звездных ветров. Главный герой, капитан корабля Bruce, быстро оценил ситуацию и приказал экипажу готовиться к эвакуации. Но когда они приблизились к спасательным шаттлам, на корабль напали странные чудища, ранее неизвестные для космической науки. Джон, взявшись за оружие и завернувшись в бронированный костюм, решил очистить корабль от нападающих и убедиться, что все члены экипажа спасены.Но впереди его ждет коварство и неожиданные опасности, так как эти чудища не только агрессивны, но и обладают умом, способным к стратегическим действиям.Битва за выживание в космосе только начинается...");
                                break;

                            case "Felicia Fleming":
                                Console.WriteLine("Флеминг — биолог и капитан космического корабля Аврора. Она специалист в области экологии и биологии и заботится о благополучии живых существ на корабле. Она также неутомимый боец и готова исполнить любую миссию, несмотря на риски и опасности. Во время рейса на Авроре она взяла на себя ответственность за спасение всех членов экипажа и противостояла неизвестным чудовищам, напавшим на корабль. Благодаря своей смелости, умению оценивать ситуацию и находить решения, Флеминг справится с любой задачей и поможет экипажу достичь цели." + "\n");
                                Console.WriteLine("Для продолжения нажмите Enter" + "\n");
                                Console.ReadKey();
                                Console.WriteLine("Космический корабль Аврора неожиданно потерял управление после прохождения через область сильных звездных ветров. Главная героиня, биолог Felicia, быстро оценила ситуацию и приказала экипажу готовиться к эвакуации. Но когда они приблизились к спасательным шаттлам, на корабль напали странные чудища, ранее неизвестные для космической науки. Felicia, взявшись за оружие и завернувшись в бронированный костюм, решила очистить корабль от нападающих и убедиться, что все члены экипажа спасены.Но впереди его ждет коварство и неожиданные опасности, так как эти чудища не только агрессивны, но и обладают умом, способным к стратегическим действиям.Битва за выживание в космосе только начинается...");
                                break;
                        }
                        Console.WriteLine("Для продолжения нажмите Enter");
                        Console.ReadLine();

                        Console.Clear();

                        Console.WriteLine("Выберите оружие");
                        Console.WriteLine("1. Shotgun | урон: 50 | оглушения нет");

                        int weaponChoice = int.Parse(Console.ReadLine());

                        if (weaponChoice < 1 || weaponChoice > inventory.Count)
                        {
                            Console.WriteLine("Неправильный выбор. Попробуйте ещё раз.");
                        }
                        else
                        {
                            Console.WriteLine("Вы выбрали " + weaponChoice);
                        }

                        Console.WriteLine("\nВы встретили врага! Начать бой?");
                        Console.WriteLine("1. Да");
                        Console.WriteLine("2. Нет");

                        int battleChoice = int.Parse(Console.ReadLine());
                        int damage_survive = 50;
                        if (battleChoice == 1)
                        {
                            for (int i = 0; i < selectedSurvivor.health; i++)
                            {

                                Enemy currentEnemy = enemies[new Random().Next(0, enemies.Count)];
                                Console.WriteLine("\nВы начали бой с " + currentEnemy.enemy);

                                while (selectedSurvivor.health > 0 && currentEnemy.health > 0)
                                {
                                    if (selectedSurvivor.health > 0)
                                    {
                                        currentEnemy.health -= damage_survive;
                                        Console.WriteLine("Герой атакует " + currentEnemy.enemy + "и наносит " + damage_survive + "урона");
                                        Console.ReadKey();
                                    }
                                    int dodgeChance = 30;
                                    Random random = new Random();

                                    if (random.Next(1, 101) <= dodgeChance)
                                    {
                                        selectedSurvivor.dodge = true;
                                        Console.WriteLine(selectedSurvivor.survivor + " увернулся от атаки " + currentEnemy.enemy + "!");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        selectedSurvivor.dodge = false;
                                        Console.WriteLine(selectedSurvivor.survivor + " не смог увернуться и получил " + currentEnemy.damage + " урона от " + currentEnemy.enemy + ".");
                                        selectedSurvivor.health -= currentEnemy.damage;
                                        Console.ReadKey();

                                        if (currentEnemy.health <= 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(currentEnemy.enemy + " погиб!");
                                            Console.WriteLine("Поздравляю, ты выиграл! Теперь ты можешь продолжить свою борьбу за выживание в этом опустошенном корабле.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Вы победили всех космических существ и показали свою мощь и мастерство в бою. Теперь, когда вы стали настоящим героем, дальнейшие вызовы не страшны!\" Поздравляем тебя с этой эпической победой, смелый боец! Надеюсь, ты насладился игрой и готов к новым приключениям!");
                                            Console.ReadKey();
                                            Console.WriteLine("Но все члены экипажа погибли... Всё бы ничего, но в корабле есть большущая дыра, вызванная метеоритом, в котором и находились эти самозвавцы!");
                                            Console.ReadKey();
                                            Console.WriteLine("Ты должен срочно залатать её!");
                                            Console.ReadKey();
                                            Console.WriteLine("Вы приблизились к месту происшествия, но заметили, что из метеорита ктото вылезает!");
                                            Console.Clear();
                                            Console.ReadKey();
                                            Console.WriteLine("                          ###############                                                               ");
                                            Console.WriteLine("                    #######################                                                           ");
                                            Console.WriteLine("                 #############################                                                        ");
                                            Console.WriteLine("               ##################################                                                       ");
                                            Console.WriteLine("             ######################################                                                     ");
                                            Console.WriteLine("            #########################################                                                   ");
                                            Console.WriteLine("          ############################################                                                   ");
                                            Console.WriteLine("         ################################################                                                 ");
                                            Console.WriteLine("        ##################################################                                               ");
                                            Console.WriteLine("       ####################################################                                              ");
                                            Console.WriteLine("      ######################################################                                             ");
                                            Console.WriteLine("     #########################################################                                           ");
                                            Console.WriteLine("     ###########################################      ########                                          ");
                                            Console.WriteLine("     #############                     #########   #  ########                                          ");
                                            Console.WriteLine("     ###############                  ##########      #####                                          ");
                                            Console.WriteLine("     ################                  #####################                                          ");
                                            Console.WriteLine("     #################                   ###################                                          ");
                                            Console.WriteLine("     ##################                    ###############                                            ");
                                            Console.WriteLine("     ###################                     #############                                            ");
                                            Console.WriteLine("     ####################                       ##########                                             ");
                                            Console.WriteLine("     #####################                          ###                                                 ");
                                            Console.WriteLine("     ######################                                                                             ");
                                            Console.WriteLine("     #######################                                                                            ");
                                            Console.WriteLine("     ########################                                                                           ");
                                            Console.WriteLine("     #########################                                                                          ");
                                            Console.WriteLine("     ##########################                                                                         ");
                                            Console.WriteLine("     ###########################                                                                        ");
                                            Console.WriteLine("     #############################                                                                      ");
                                            Console.WriteLine("     ##############################                                                                     ");
                                            Console.WriteLine("     ###############################                                                                 ");
                                            Console.WriteLine("     ################################                                                               ");
                                            Console.WriteLine("     #################################                                                                ");
                                            Console.WriteLine("     ##################################         #######                                                 ");
                                            Console.WriteLine("     ####################################     ###########                                               ");
                                            Console.WriteLine("     #######################################################                                             ");
                                            Console.WriteLine("     ########################################################                                            ");
                                            Console.WriteLine("     ###########   ###########################################                                            ");
                                            Console.WriteLine("     ###########    ########################################                                              ");
                                            Console.WriteLine("     ###########     #####################################                                               ");
                                            Console.WriteLine("     ############      #################################                                                ");
                                            Console.WriteLine("     #############     ###############################                                                  ");
                                            Console.WriteLine("      #############     ############################                                                    ");
                                            Console.WriteLine("      ##############     ##########################                                                      ");
                                            Console.WriteLine("      ###############     ########################                                                        ");
                                            Console.WriteLine("       ###############     ####################                                                          ");
                                            Console.WriteLine("       ################     #################                                                           ");
                                            Console.WriteLine("        #################     ###############                                                             ");
                                            Console.WriteLine("        ###################     ############                                                              ");
                                            Console.WriteLine("          ###################     ##########                                                               ");
                                            Console.WriteLine("          #####################     #######                                                                ");
                                            Console.WriteLine("             #####################      ##                                                                  ");
                                            Console.WriteLine("             #######################                                                                         ");
                                            Console.WriteLine("              #######################                                                                        ");
                                            Console.WriteLine("              ########################                                                                       ");
                                            Console.WriteLine("                ########################                                                                     ");
                                            Console.WriteLine("                #########################                                                                    ");
                                            Console.WriteLine("                  ##########################                                                                 ");
                                            Console.WriteLine("                   ###########################                                                               ");
                                            Console.WriteLine("                   ############################                                                             ");
                                            Console.WriteLine("                    ############################                                                            ");
                                            Console.WriteLine("                    #############################                                                           ");
                                            Console.WriteLine("                      ############################                                                           ");
                                            Console.WriteLine("                      ############################                                                           ");
                                            Console.WriteLine("                   ################################                                                         ");
                                            Console.WriteLine("               #######################################                                                      ");
                                            Console.WriteLine("              ##########################################                                                      ");
                                            Console.WriteLine("            #############################################                                                     ");
                                            Console.WriteLine("            ##############################################                                                ");
                                            Console.WriteLine("           ###############################################                                             ");
                                            Console.WriteLine("          #########      ###################################                                            ");
                                            Console.WriteLine("         ##########      ##################################                                           ");
                                            Console.WriteLine("         ##########      ################################                                           ");
                                            Console.WriteLine("         ##########      ###############  ################                                          ");
                                            Console.WriteLine("         #########       ############   ##################                                      ");
                                            Console.WriteLine("         ########        ##########     ##################                                    ");
                                            Console.WriteLine("          ######         #######        ##################                                  ");
                                            Console.WriteLine("            ###          ####           ###################                                  ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.ReadKey();
                                            Console.WriteLine("Продолжение следует");
                                            Console.ReadKey();
                                            Console.ReadKey();
                                            Console.ReadKey();
                                            Console.ReadKey();
                                            Console.ReadKey();

                                            break;
                                        }
                                        else if (selectedSurvivor.health <= 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(selectedSurvivor.survivor + " погиб!");
                                            Console.ReadKey();
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine(selectedSurvivor.survivor + " имеет " + selectedSurvivor.health + " здоровья. " + currentEnemy.enemy + " имеет " + currentEnemy.health + " здоровья.");
                                            Console.WriteLine("\nНажмите Enter, чтобы продолжить.");
                                            Console.ReadKey();
                                        }
                                    }
                                }
                            }
                         }
                    }
                }
            }
        }
    }
}
    



    








                        
                    
                
            
        
    




