using SEDC.Adv.TryBeingFit.Domain.Entities;
using SEDC.Adv.TryBeingFit.Domain.Enums;
using SEDC.Adv.TryBeingFit.Services.Helpers;
using SEDC.Adv.TryBeingFit.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Adv.TryBeingFit.App
{
    class Program
    {
		public static UIService _uiService = new UIService();
		public static UserService<StandardUser> _standardUserService = 
			new UserService<StandardUser>();
		public static UserService<PremiumUser> _premiumUserSrvc =
			new UserService<PremiumUser>();
		public static UserService<TrainerUser> _trainerUserSrvc =
			new UserService<TrainerUser>();
		public static TrainingServices<VideoTraining> _videoTrainingSrvc =
			new TrainingServices<VideoTraining>();
		public static TrainingServices<LiveTraining> _liveTrainingSrvc =
			new TrainingServices<LiveTraining>();
		public static User _currentUser;
		public static void Seed()
		{
			_standardUserService.Register(new StandardUser() { FirstName = "Bob", LastName = "Bobsky", Username = "bobob1", Password = "bobbest1" });
			_premiumUserSrvc.Register(new PremiumUser() { FirstName = "Jill", LastName = "Wayne", Username = "jilllw", Password = "jillsuper26" });
			TrainerUser John = new TrainerUser() { FirstName = "John", LastName = "Johnsky", Username = "johnjj", Password = "johny55", YearsExperience = 7 };
			_trainerUserSrvc.Register(John);
			_videoTrainingSrvc.AddTraining(new VideoTraining() { Title = "30 min workout", Description = "Cool workout for beginners and intermediate users", Difficulty = Difficulty.Medium, Link = "https://www.youtube.com/watch?v=50kH47ZztHs", Rating = 4, Time = 35 });
			_videoTrainingSrvc.AddTraining(new VideoTraining() { Title = "Standing ABS workout", Description = "Abs workout for people at home with standing and no equipment required", Difficulty = Difficulty.Easy, Link = "https://www.youtube.com/watch?v=Qia2ZXEzyLw", Rating = 5, Time = 11 });
			_videoTrainingSrvc.AddTraining(new VideoTraining() { Title = "Full AGILITY Bodyweight", Description = "An intense workout for people that have experience working out and need a good AGILITY training", Difficulty = Difficulty.Hard, Link = "https://www.youtube.com/watch?v=tveIjnSG_8s", Rating = 2, Time = 67 });
			_liveTrainingSrvc.AddTraining(new LiveTraining() { Title = "Workout with John", Description = "Working out can be easy when you are at home. Trust John, he is a professional!", Difficulty = Difficulty.Medium, NextSession = new DateTime(2020, 07, 20), Trainer = John, Time = 25 });
			_liveTrainingSrvc.AddTraining(new LiveTraining() { Title = "Quick abs with John", Description = "You want abs for the summer? You want them quick? This is the training for you!", Difficulty = Difficulty.Hard, NextSession = new DateTime(2020, 07, 24), Trainer = John, Time = 40 });

		}
		static void Main(string[] args)
		{
			Seed();
            while (true)
            {
				if(_currentUser == null)
                {
					int loginChoice = _uiService.RoleMenu();
					if(loginChoice == 1)
                    {
						int roleChoice = _uiService.RoleMenu();
						UserRole role = (UserRole)roleChoice;
						Console.Clear();
						Console.WriteLine("Enter username: ");
						string username = Console.ReadLine();
						Console.WriteLine("Enter password: ");
						string password = Console.ReadLine();
                        switch (role)
                        {
							case UserRole.Standard:
								_currentUser = _standardUserService.LogIn(username, password);
								break;
							case UserRole.Premium:
								_currentUser = _premiumUserSrvc.LogIn(username, password);
								break;
							case UserRole.Trainer:
								_currentUser = _trainerUserSrvc.LogIn(username, password);
								break;
							
                            default:
								throw new Exception("INVALID ROLE");
                        }
						if (_currentUser == null) continue;
                    }
					else
					{
						StandardUser newUser = new StandardUser();
                        Console.WriteLine("Enter First Name");
						newUser.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
						newUser.LastName = Console.ReadLine();
                        Console.WriteLine("Enter User Name");
						newUser.Username = Console.ReadLine();
                        Console.WriteLine("Enter Password");
						newUser.Password = Console.ReadLine();
						User user = _standardUserService.Register(newUser);
						if (user == null) continue;
						_currentUser = user;
					}
					_uiService.Welcome(_currentUser);
				}
				int mainManuChoise = _uiService.MainMenu(_currentUser.Role);
				string mainManuItem = _uiService.MainMenuItems[mainManuChoise - 1];
                switch (mainManuItem)
                {
					case "Train":
						int trainChoice = 1;
						if (_currentUser.Role == UserRole.Premium)
							trainChoice = _uiService.TrainMany();
						if (trainChoice == 2)
						{
							int trainingItem = _uiService.TrainManyItems(_videoTrainingSrvc.GetTrainings());
							VideoTraining training = _videoTrainingSrvc.GetTrainings()[trainingItem - 1];
							Console.WriteLine(training.Title);
							Console.WriteLine($"Link: {training.Link}");
							Console.WriteLine($"Rating: {training.CheckRating()}");
							Console.ReadLine();
						}
						if (trainChoice == 1)
						{
							int trainingItem = _uiService.TrainManyItems(_liveTrainingSrvc.GetTrainings());
							LiveTraining training = _liveTrainingSrvc.GetTrainings()[trainingItem - 1];
							Console.WriteLine(training.Title);
							Console.WriteLine($"Time for next session: {training.NextSession}");
							Console.WriteLine($"Time: {training.Time}");
							Console.ReadLine();
						}
						break;
					case "Upgrade to Premium":
						_uiService.UpgradeToPremium();
						break;
					case "Reschedule training":
						List<LiveTraining> trainings = _liveTrainingSrvc.GetTrainings()
							.Where(x => x.Trainer.Id == _currentUser.Id).ToList();
						if(trainings.Count == 0)
                        {
							Console.WriteLine("No trainings");
							Console.ReadLine();
						}
                        else
                        {
							int trainingChoice = _uiService.ChooseEntiiesMenu(trainings);
							Console.WriteLine("How many days do you want to reschedule the training");
							int days = ValidationHelper.ValidateNumber(Console.ReadLine(), 30);
							_trainerUserSrvc.GetById(_currentUser.Id).ChangeSchedule(trainings[trainingChoice - 1], days);
							Console.WriteLine("Schedule changed!");
							Console.ReadLine();
						}
						break;
					case "Account":
						int accountChoice = _uiService.AccountMenu();
						Console.Clear();
						if(accountChoice == 1)
                        {
							// Change Info
							Console.WriteLine("Enter new First Name:");
							string firstName = Console.ReadLine();
							Console.WriteLine("Enter new Last Name:");
							string lastName = Console.ReadLine();
                            switch (_currentUser.Role)
                            {
                                case UserRole.Standard:
									_standardUserService.changeInfo(_currentUser.Id, firstName, lastName);
                                    break;
                                case UserRole.Premium:
									_premiumUserSrvc.changeInfo(_currentUser.Id, firstName, lastName);
                                    break;
                                case UserRole.Trainer:
									_trainerUserSrvc.changeInfo(_currentUser.Id, firstName, lastName);
                                    break;                               
                            }
                        }
						else if(accountChoice == 2)
                        {
                            // Check Subscription
                            Console.WriteLine($"Your subscription is: {_currentUser.Role}");
							Console.ReadLine();
                        }
						else if(accountChoice == 3)
                        {
							// Change Info
							Console.WriteLine("Enter old password:");
							string oldPass = Console.ReadLine();
							Console.WriteLine("Enter new password:");
							string newPass = Console.ReadLine();
                            switch (_currentUser.Role)
                            {
                                case UserRole.Standard:
									_standardUserService.ChangePassword(_currentUser.Id, oldPass, newPass);
                                    break;
                                case UserRole.Premium:
									_premiumUserSrvc.ChangePassword(_currentUser.Id, oldPass, newPass);
                                    break;
                                case UserRole.Trainer:
									_trainerUserSrvc.ChangePassword(_currentUser.Id, oldPass, newPass);
                                    break;
                               
                            }
                        }
						break;
					case "Log Out":
						_currentUser = null;
						break;
					default:
                        break;
                }

            }
			
		}
	}
}
