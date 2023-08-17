using System;
using System.Reflection;

partial class Program
{
    static void Main(string[] args)
    {

        #region Attr
        //Update[] updates = {
        //    new Update(1, "Security Update"),
        //    new Update(2, "ui enhancements"),
        //    new Update(3, "No. of bug fixes updates"),
        //    new Update(4, "Security Update"),
        //};
        //UpdateProcessor.Download(updates);
        //UpdateProcessor.Install(updates);
        //UpdateProcessor.DownloadAndInstall(updates); 
        #endregion

        List<Player> players = new List<Player>
        {
            new Player
            {
                Name = "Messi",
                BallControl = 9,
                Dribbling = 13,
                Passing = 4,
                Speed = 85,
                Power = 980
            },
            new Player
            {
                Name = "Ronaldo",
                BallControl = 9,
                Dribbling = 15,
                Passing = 7,
                Speed = 99,
                Power = 1010
            },
            new Player
            {
                Name = "Naymar Jr",
                BallControl = 7,
                Dribbling = 10,
                Passing = 4,
                Speed = 82,
                Power = 960
            }
        };

        var errors = new List<Error>();

        foreach (var player in players)
        {
            var properties = player.GetType().GetProperties();
            foreach (var prop in properties)
            {
                var skillAttribute = prop.GetCustomAttribute<SkillAttribute>(); 
                if(skillAttribute is not null)
                {
                    var value = prop.GetValue(player);
                    if (!skillAttribute.IsValid(value))
                    {
                        errors.Add(new Error(prop.Name,
                            $"Invalid Value Accepted Rang is {skillAttribute.Minimum}-{skillAttribute.Maximum}"));
                    }
                }
            }
        }
        if (errors.Count > 0)
        {
            foreach (var e in errors)
            {
                Console.WriteLine(e);
            }

        }
        else
        {
            Console.WriteLine("Players info is valid");
        }

        Console.ReadKey();
    }
    public class Player
    {
        public string Name { get; set; }

        [Skill(nameof(BallControl),1, 10)]
        public int BallControl { get; set; } // 1 - 10

        [Skill(nameof(Dribbling), 1, 20)]
        public int Dribbling { get; set; } // 1 - 20

        [Skill(nameof(Power), 1, 1000)]
        public int Power { get; set; }  // 1 - 1000

        [Skill(nameof(Speed), 1, 100)]
        public int Speed { get; set; } // 1 - 100

        [Skill(nameof(Passing), 1, 4)]
        public int Passing { get; set; } // 1 - 4

    }

    public class SkillAttribute : Attribute
    {
        public string Name { get; private set; }
        public int Minimum { get; private set; }
        public int Maximum { get; private set; }

        public SkillAttribute(string name, int minimum, int maximum)
        {
            Name = name;
            Minimum = minimum;
            Maximum = maximum;
        }
        public bool IsValid(object obj)
        {
            var value = (int)obj;
            return value >= Minimum && value <= Maximum; 
        }
    }

    public class Error
    {
        private string field;
        private string details;

        public Error(string field, string details)
        {
            this.field = field;
            this.details = details;
        }
        public override string ToString()
        {
            return $"{{\"{field}\": \"{details}\"}}";
        }
    }
}