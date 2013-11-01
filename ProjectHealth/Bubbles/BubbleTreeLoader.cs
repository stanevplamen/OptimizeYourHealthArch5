using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    /// <summary>
    /// Main bubble
    /// Main nodes
    /// Secondary children
    /// Third children leafs
    /// </summary>
    public class BubbleTreeLoader
    {
        public static int counter = 0;

        public static List<Bubble> bubbleTree;

        #region Basic Health Principles

        public static BasicHealthPrinciples basicPrinciples;
        public static BasicHealthPrinciplesInfo basicHealthInfo;

        public static Nutrition nutrition;
        public static Sport sport;
        public static RestTime restTime;
        public static SameDays sameDays;
        public static Rules rules;

        public static Carbohydrates carbohydrates;
        public static DifferentFood differentFood;
        public static FiveTimes fiveTimes;
        public static HoneyLemon honeyLemon;
        public static Proteins proteins;
        public static RawFood rawFood;
        public static TwoHBefore twoHBefore;
        public static Water water;

        public static AchievableGoals achievableGoals;
        public static ExtremeSports extremeSports;
        public static JoggingFitness joggingFitness;
        public static PersonalPreferences personalPreferences;

        public static BalancedDiet balancedDiet;
        public static Honey honey;
        public static LessSalt lessSalt;
        public static MoreWater moreWater;
        public static RegularMeals regularMeals;
        public static Sweets sweets;
        public static VariedDiet variedDiet;
        public static VariedFats variedFats;
        public static WholeMeals wholemeals;

        #endregion Basic Health Principles

        #region Effective comunication

        public static Comunication comunication;
        public static Desire desire;

        public static Approach approach;
        public static Cycle cycle;
        public static Models models;
        public static Stages stages;
        public static Techniques techniques;

        public static Egocentrism egocentrism;
        public static HealthySelfishness healthySelfishness;

        public static QualityOfFunctioning qualityOfFunctioning;

        public static Adaptation adaptation;
        public static Aggression aggresion;
        public static Humility humility;
        public static Seduction seduction;

        public static Closing closing;
        public static Connection connection;
        public static Differentiation differentiation;

        public static ClearDesire clearDesire;
        public static Disclaimer disclaimer;
        public static EffectiveSolutions effectiveSolutions;
        public static Limits limits;
        public static PositiveAttitude positiveAttitude;

        #endregion Effective comunication

        #region Healthy Food

        public static HealthyFoodInfo healthyFoodInfo;

        public static CaloricIntake caloricIntake;
        public static FoodInfluence foodInfluence;
        public static GoodPractices goodPractices;
        public static Pyramid pyramid;
        public static StressHandling stressHandling;
        public static SuperFoods superFoods;
        public static VitaminsAndMinerals vitaminsAndMinerals;

        public static BMIIndex bmiIndex;

        public static Caffeine caffeine;
        public static CarbohydratesHealthy carboHealthy;
        public static Fats fats;
        public static ProteinsHealth protHealthy;
        public static Sugar sugar;

        public static Alternation alternation;
        public static FiveTimesHealthy fiveHealthy;
        public static Fluid fluid;
        public static TurnHabit turnHabit;

        public static Algae algae;
        public static Animal animal;
        public static Plant plant;

        #endregion Healthy Food

        #region Restorative Movement

        public static RestorativeMovement restorativeMovement;

        public static HeadPosition headPosition;
        public static NaturalMovement naturalMovement;
        public static SeatedPosition seatedPosition;
        public static Stretching stretching;
        public static UprigthPosition uprigthPosition;
        public static Rule300 rule300;

        public static OverTheShoulders overTheShoulders;

        public static Climbing climbing;
        public static Continious continious;
        public static Squat squat;
        public static Walking walking;

        public static Breathing breathing;
        public static Neck neck;
        public static OnFloor onFloor;
        public static OnPelvis onPelvis;

        public static Balance balance;
        public static TwoTimes twoTimes;
        public static WalkingFiveKm walkingFiveKm;

        public static ShouldersAboveFeet shouldersAboveFeet;
        public static WeigthOnHeels weigthOnHeels;
        public static WorkingUprigth workingUprigth;

        #endregion Restorative Movement

        #region WorkAndLive

        public static WorkAndLive workAndLive;

        public static BadPracticesWork badPracticesWork;
        public static CareForOurselves careForOurselves;
        public static ControlInWork controlInWork;
        public static DoMoreHappy doMoreHappy;
        public static StressMeasures stressMeasures;

        public static BadEffect badEffect;
        public static Fatigue fatigue;
        public static Grizzling grizzling;
        public static NigthWorking nigthWorking;
        public static NoFreeTime noFreeTime;
        public static NoLunchBreak noLunchBreak;
        public static NoRest noRest;
        public static TemperLoss temperLoss;

        public static FavouritePeople favouritePeople;
        public static HealthCare healthCare;
        public static Journeys journeys;
        public static Vacartion vacantion;

        public static Delegation delegation;
        public static SayingNo sayingNo;
        public static TimePlan timePlan;
        public static TodoLists todoLists;

        public static BodyCare bodyCare;
        public static FamilyCare familyCare;
        public static FinanceCare financeCare;
        public static HealthyNutrition healthyNutrition;
        public static MindDevelipment mindDevelopment;
        public static SocialNetworking socialNetworking;

        public static Dissolution dissolition;
        public static Exercises exercises;
        public static NoOverloads noOverloads;
        public static Relaxation relaxation;
 
        #endregion WorkAndLive


        public static void InitializeTree()
        {
            #region Basic Health Principles

            basicPrinciples = new BasicHealthPrinciples(counter++, "Basic Principles of Healthy Living");
            basicHealthInfo = new BasicHealthPrinciplesInfo(counter++, "Basic Principles of Healthy Living");

            nutrition = new Nutrition(counter++, "Nutrition");
            sport = new Sport(counter++, "Sport");
            restTime = new RestTime(counter++, "Resting time");
            sameDays = new SameDays(counter++, "Same days feeling well");
            rules = new Rules(counter++, "Some base rules for healthy living");

            carbohydrates = new Carbohydrates(counter++, "Carbohydrates");
            differentFood = new DifferentFood(counter++, "Different Food");
            fiveTimes = new FiveTimes(counter++, "Five Times Eating");
            honeyLemon = new HoneyLemon(counter++, "Honey and Lemons");
            proteins = new Proteins(counter++, "Proteins");
            rawFood = new RawFood(counter++, "Raw Food");
            twoHBefore = new TwoHBefore(counter++, "Eating two hours before sleep");
            water = new Water(counter++, "Water");

            achievableGoals = new AchievableGoals(counter++, "Achievable goals");
            extremeSports = new ExtremeSports(counter++, "Extreme Sports");
            joggingFitness = new JoggingFitness(counter++, "Jogging and Fitness");
            personalPreferences = new PersonalPreferences(counter++, "Personal sport preferences");

            balancedDiet= new BalancedDiet(counter++, "Balanced Diet");
            honey = new Honey(counter++, "Honey");
            lessSalt = new LessSalt(counter++, "Less Salt");
            moreWater = new MoreWater(counter++, "More Water");
            regularMeals = new RegularMeals(counter++, "Regular Meals");
            sweets = new Sweets(counter++, "Sweets");
            variedDiet = new VariedDiet(counter++, "Varied Diet");
            variedFats = new VariedFats(counter++, "Varied Fats");
            wholemeals = new WholeMeals(counter++, "Wholemeals");

            #endregion Basic Health Principles

            #region Effective comunication

            comunication = new Comunication(counter++, "Comunication");
            desire = new Desire(counter++, "Desire occurence");

            approach = new Approach(counter++, "Personal Approach");
            cycle = new Cycle(counter++, "Cycle of comunication");
            models = new Models(counter++, "Models of comunication");
            stages = new Stages(counter++, "Stages of comunication");
            techniques = new Techniques(counter++, "Techniques of comunication");

            egocentrism = new Egocentrism(counter++, "Egocentrism");
            healthySelfishness = new HealthySelfishness(counter++, "Healthy Selfishness");

            qualityOfFunctioning = new QualityOfFunctioning(counter++, "Quality of functioning");

            adaptation = new Adaptation(counter++, "Adaptation");
            aggresion = new Aggression(counter++, "Aggresion");
            humility = new Humility(counter++, "Humility");
            seduction = new Seduction(counter++, "Seduction");

            closing = new Closing(counter++, "Closing");
            connection = new Connection(counter++, "Connection");
            differentiation = new Differentiation(counter++, "Differentiation");

            clearDesire = new ClearDesire(counter++, "Clear Desire");
            disclaimer = new Disclaimer(counter++, "Disclaimer");
            effectiveSolutions = new EffectiveSolutions(counter++, "Effective Solutions");
            limits = new Limits(counter++, "Limits");
            positiveAttitude = new PositiveAttitude(counter++, "Positive attitude");

            #endregion Effective comunication

            #region Healthy Food

            healthyFoodInfo = new HealthyFoodInfo(counter++, "Healthy Food");

            caloricIntake = new CaloricIntake(counter++, "Caloric Intake");
            foodInfluence = new FoodInfluence(counter++, "Food Influence");
            goodPractices = new GoodPractices(counter++, "Good Practices");
            pyramid = new Pyramid(counter++, "Food Pyramid");
            stressHandling = new StressHandling(counter++, "Stress Handling");
            superFoods = new SuperFoods(counter++, "Super Foods");
            vitaminsAndMinerals = new VitaminsAndMinerals(counter++, "Vitamins and Minerals");

            bmiIndex = new BMIIndex(counter++, "Body Mass Index");

            caffeine = new Caffeine(counter++, "Caffeine");
            carboHealthy = new CarbohydratesHealthy(counter++, "Carbohydrates");
            fats = new Fats(counter++, "Fats");
            protHealthy = new ProteinsHealth(counter++, "Proteins");
            sugar = new Sugar(counter++, "Sugar");

            alternation = new Alternation(counter++, "Alternation");
            fiveHealthy = new FiveTimesHealthy(counter++, "Five Times a Day");
            fluid = new Fluid(counter++, "Fluids");
            turnHabit = new TurnHabit(counter++, "Turn the good practive to habit");

            algae = new Algae(counter++, "Algae super foods");
            animal = new Animal(counter++, "Animal super foods");
            plant = new Plant(counter++, "Plant super foods");

            #endregion Healthy Food

            #region Restorative Movement

            restorativeMovement = new RestorativeMovement(counter++, "Healthy Food");

            headPosition = new HeadPosition(counter++, "Head Position(");
            naturalMovement = new NaturalMovement(counter++, "Natural Movement");
            seatedPosition = new SeatedPosition(counter++, "Seated Position");
            stretching = new Stretching(counter++, "Stretching");
            uprigthPosition = new UprigthPosition(counter++, "Uprigth Position");
            rule300 = new Rule300(counter++, "Rule 300");

            overTheShoulders = new OverTheShoulders(counter++, "OverTheShoulders");

            climbing = new Climbing(counter++, "Climbing");
            continious = new Continious(counter++, "Continious Movement");
            squat = new Squat(counter++, "Squat");
            walking = new Walking(counter++, "Walking");

            breathing = new Breathing(counter++, "Breathing");
            neck = new Neck(counter++, "Neck Position");
            onFloor = new OnFloor(counter++, "Seating on floor");
            onPelvis = new OnPelvis(counter++, "Seating on pelvis");

            balance = new Balance(counter++, "Balanced stretching");
            twoTimes = new TwoTimes(counter++, "Stretching at least two times a day");
            walkingFiveKm = new WalkingFiveKm(counter++, "Walking five kilometers daily");

            shouldersAboveFeet = new ShouldersAboveFeet(counter++, "Shoulders Above Feet");
            weigthOnHeels = new WeigthOnHeels(counter++, "Weigth on heels");
            workingUprigth = new WorkingUprigth(counter++, "Working uprigth");

            #endregion Restorative Movement

            #region WorkAndLive

            workAndLive = new WorkAndLive(counter++, "Healthy Food");

            badPracticesWork = new BadPracticesWork(counter++, "Some bad practices in work");
            careForOurselves = new CareForOurselves(counter++, "Care for ourselves");
            controlInWork = new ControlInWork(counter++, "Control in the work");
            doMoreHappy = new DoMoreHappy(counter++, "Do more of what makes you happy");
            stressMeasures = new StressMeasures(counter++, "Stress measures");

            badEffect = new BadEffect(counter++, "Bad Effect");
            fatigue = new Fatigue(counter++, "Fatigue");
            grizzling = new Grizzling(counter++, "Grizzling");
            nigthWorking = new NigthWorking(counter++, "NigthWorking");
            noFreeTime = new NoFreeTime(counter++, "oFreeTime");
            noLunchBreak = new NoLunchBreak(counter++, "NoLunchBreak");
            noRest = new NoRest(counter++, "NoRest");
            temperLoss = new TemperLoss(counter++, "TemperLoss");

            favouritePeople = new FavouritePeople(counter++, "FavouritePeople");
            healthCare = new HealthCare(counter++, "HealthCare");
            journeys = new Journeys(counter++, "Journeys(");
            vacantion = new Vacartion(counter++, "Vacartion");

            delegation = new Delegation(counter++, "Delegation");
            sayingNo = new SayingNo(counter++, "SayingNo ");
            timePlan = new TimePlan(counter++, "TimePlan");
            todoLists = new TodoLists(counter++, "TodoLists");

            bodyCare = new BodyCare(counter++, "BodyCare ");
            familyCare = new FamilyCare(counter++, "FamilyCare ");
            financeCare = new FinanceCare (counter++, "Stress measures");
            healthyNutrition = new HealthyNutrition(counter++, "HealthyNutrition ");
            mindDevelopment = new MindDevelipment(counter++, "MindDevelipment");
            socialNetworking = new SocialNetworking(counter++, "SocialNetworking ");

            dissolition = new Dissolution(counter++, "Dissolution ");
            exercises = new Exercises (counter++, "Exercises ");
            noOverloads = new NoOverloads(counter++, "NoOverloads ");
            relaxation = new Relaxation(counter++, "Relaxation ");

            #endregion WorkAndLive

            bubbleTree = BubbleInitializer();
        }

        #region Load the bubble structure

        private static List<Bubble> BubbleInitializer()
        {
            if (bubbleTree == null)
            {
                CreateLists();
            }
            return bubbleTree;
        }

        private static void CreateLists()
        {
            bubbleTree = new List<Bubble>();
            bubbleTree.Add(basicPrinciples);

            bubbleTree.Add(basicHealthInfo );

            bubbleTree.Add(nutrition           );
            bubbleTree.Add(sport               );
            bubbleTree.Add(restTime            );
            bubbleTree.Add(sameDays            );
            bubbleTree.Add(rules               );

            bubbleTree.Add(carbohydrates       );
            bubbleTree.Add(differentFood       );
            bubbleTree.Add(fiveTimes           );
            bubbleTree.Add(honeyLemon          );
            bubbleTree.Add(proteins            );
            bubbleTree.Add(rawFood             );
            bubbleTree.Add(twoHBefore          );
            bubbleTree.Add(water               );

            bubbleTree.Add(achievableGoals     );
            bubbleTree.Add(extremeSports       );
            bubbleTree.Add(joggingFitness      );
            bubbleTree.Add(personalPreferences );

            bubbleTree.Add(balancedDiet        );
            bubbleTree.Add(honey               );
            bubbleTree.Add(lessSalt            );
            bubbleTree.Add(moreWater           );
            bubbleTree.Add(regularMeals        );
            bubbleTree.Add(sweets              );
            bubbleTree.Add(variedDiet          );
            bubbleTree.Add(variedFats          );
            bubbleTree.Add(wholemeals          );
            bubbleTree.Add(comunication        );
            bubbleTree.Add(desire              );

            bubbleTree.Add(approach            );
            bubbleTree.Add(cycle               );
            bubbleTree.Add(models              );
            bubbleTree.Add(stages              );
            bubbleTree.Add(techniques          );

            bubbleTree.Add(egocentrism         );
            bubbleTree.Add(healthySelfishness  );

            bubbleTree.Add(qualityOfFunctioning);

            bubbleTree.Add(adaptation          );
            bubbleTree.Add(aggresion           );
            bubbleTree.Add(humility            );
            bubbleTree.Add(seduction           );

            bubbleTree.Add(closing             );
            bubbleTree.Add(connection          );
            bubbleTree.Add(differentiation     );

            bubbleTree.Add(clearDesire         );
            bubbleTree.Add(disclaimer          );
            bubbleTree.Add(effectiveSolutions  );
            bubbleTree.Add(limits              );
            bubbleTree.Add(positiveAttitude    );

            bubbleTree.Add(healthyFoodInfo     );

            bubbleTree.Add(caloricIntake       );
            bubbleTree.Add(foodInfluence       );
            bubbleTree.Add(goodPractices       );
            bubbleTree.Add(pyramid             );
            bubbleTree.Add(stressHandling      );
            bubbleTree.Add(superFoods          );
            bubbleTree.Add(vitaminsAndMinerals );

            bubbleTree.Add(bmiIndex            );

            bubbleTree.Add(caffeine            );
            bubbleTree.Add(carboHealthy        );
            bubbleTree.Add(fats                );
            bubbleTree.Add(protHealthy         );
            bubbleTree.Add(sugar               );

            bubbleTree.Add(alternation         );
            bubbleTree.Add(fiveHealthy         );
            bubbleTree.Add(fluid               );
            bubbleTree.Add(turnHabit           );

            bubbleTree.Add(algae               );
            bubbleTree.Add(animal              );
            bubbleTree.Add(plant               );

            bubbleTree.Add(restorativeMovement );

            bubbleTree.Add(headPosition        );
            bubbleTree.Add(naturalMovement     );
            bubbleTree.Add(seatedPosition      );
            bubbleTree.Add(stretching          );
            bubbleTree.Add(uprigthPosition     );
            bubbleTree.Add(rule300             );

            bubbleTree.Add(overTheShoulders    );

            bubbleTree.Add(climbing            );
            bubbleTree.Add(continious          );
            bubbleTree.Add(squat               );
            bubbleTree.Add(walking             );

            bubbleTree.Add(breathing           );
            bubbleTree.Add(neck                );
            bubbleTree.Add(onFloor             );
            bubbleTree.Add(onPelvis            );

            bubbleTree.Add(balance             );
            bubbleTree.Add(twoTimes            );
            bubbleTree.Add(walkingFiveKm       );

            bubbleTree.Add(shouldersAboveFeet  );
            bubbleTree.Add(weigthOnHeels       );
            bubbleTree.Add(workingUprigth      );

            bubbleTree.Add(workAndLive         );

            bubbleTree.Add(badPracticesWork    );
            bubbleTree.Add(careForOurselves    );
            bubbleTree.Add(controlInWork       );
            bubbleTree.Add(doMoreHappy         );
            bubbleTree.Add(stressMeasures      );

            bubbleTree.Add(badEffect           );
            bubbleTree.Add(fatigue             );
            bubbleTree.Add(grizzling           );
            bubbleTree.Add(nigthWorking        );
            bubbleTree.Add(noFreeTime          );
            bubbleTree.Add(noLunchBreak        );
            bubbleTree.Add(noRest              );
            bubbleTree.Add(temperLoss          );

            bubbleTree.Add(favouritePeople     );
            bubbleTree.Add(healthCare          );
            bubbleTree.Add(journeys            );
            bubbleTree.Add(vacantion           );

            bubbleTree.Add(delegation          );
            bubbleTree.Add(sayingNo            );
            bubbleTree.Add(timePlan            );
            bubbleTree.Add(todoLists           );

            bubbleTree.Add(bodyCare            );
            bubbleTree.Add(familyCare          );
            bubbleTree.Add(financeCare         );
            bubbleTree.Add(healthyNutrition    );
            bubbleTree.Add(mindDevelopment     );
            bubbleTree.Add(socialNetworking    );

            bubbleTree.Add(dissolition         );
            bubbleTree.Add(exercises           );
            bubbleTree.Add(noOverloads         );
            bubbleTree.Add(relaxation          );
        }

        #endregion
    }
}
