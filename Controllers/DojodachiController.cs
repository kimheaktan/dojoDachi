using Microsoft.AspNetCore.Http;
using dojodachi.Models;
using  System;
using Microsoft.AspNetCore.Mvc;

namespace dojodachi.Controllers 
{
    public class DojodachiController : Controller
    {
        [HttpGet("")]
        public IActionResult Home()
        {
            Dachi myPet = new Dachi();
            HttpContext.Session.SetObjectAsJson("myPet", myPet);
            return View(myPet);
        }

        [HttpPost("feed")]
        public IActionResult Feed()
        {
            Dachi myPet = HttpContext.Session.GetObjectFromJson<Dachi>("myPet");
            Random rand = new Random(); 
            int randChance = rand.Next(4); // 25% chance, 4 is exclusive upper boundary
            int randFullness = rand.Next(5,11);

            if(myPet.Meals <= 0){
            //OR...// if( (myPet.Meals -1) < 0){
                HttpContext.Session.SetString("Message", "Your pet is out of meal!");
                HttpContext.Session.SetObjectAsJson("myPet", myPet);
                HttpContext.Session.SetString("Image", "~/images/out.gif");
            }
            else
            {
                myPet.Meals -= 1;
                if(randChance == 0)
                {
                    HttpContext.Session.SetObjectAsJson("myPet", myPet);
                    HttpContext.Session.SetString("Message", "Didn't like what you fed them! ,Fullness stays the same and meals was decreased by 1");
                    HttpContext.Session.SetString("Image", "~/images/noOrdie.gif");
                    
                    return RedirectToAction("AfterActivity");
                }
                else
                {
                    myPet.Fullness += randFullness;
                    HttpContext.Session.SetObjectAsJson("myPet", myPet);
                    HttpContext.Session.SetString("Message", $"-1 meal and Fullness +" + randFullness );
                    HttpContext.Session.SetString("Image", "~/images/happy.jpeg");

                    return RedirectToAction("AfterActivity");
                }
            }            
            return RedirectToAction("AfterActivity");
        }

        [HttpGet("dojodachi")]
        public IActionResult AfterActivity()
        {
            Dachi myPet = HttpContext.Session.GetObjectFromJson<Dachi>("myPet");
            if(myPet.Fullness >= 100 && myPet.Energy >= 100 && myPet.Happiness >=100)
            {
                return RedirectToAction("Win");
            }
            else if(myPet.Fullness <= 0 || myPet.Happiness <= 0)
            {
                return RedirectToAction("Lose");
            }
            else
            {
                ViewBag.message = HttpContext.Session.GetString("Message");
                string im = HttpContext.Session.GetString("Image");
                ViewBag.image = Url.Content(im);

                
            }
            return View("AfterActivity" ,myPet);
        }

        [HttpPost("play")]
        public IActionResult Play()
        {
            Dachi pet = HttpContext.Session.GetObjectFromJson<Dachi>("myPet");
            Random rand = new Random();
            int randChance = rand.Next(4);
            int randHappiness = rand.Next(5,11);
            
            if(pet.Energy <= 0)
            {
                HttpContext.Session.SetObjectAsJson("myPet", pet);
                HttpContext.Session.SetString("Message", "Your pet is out of Energy!");
                HttpContext.Session.SetString("Image", "~/images/noOrdie.gif");

            }
            else{
                pet.Energy -= 5;

                if(randChance == 0)
                {
                HttpContext.Session.SetObjectAsJson("myPet", pet);
                HttpContext.Session.SetString("Message", "Your pet didn't like it, so the Happiness stays the same but the Energy is decreased by 5");
                HttpContext.Session.SetString("Image", "~/images/noOrdie.gif");
                return RedirectToAction("AfterActivity");
                
                }
                else{
                pet.Happiness += randHappiness;
                HttpContext.Session.SetObjectAsJson("myPet", pet);
                HttpContext.Session.SetString("Message", "Fun! Enery +5 and Happiness went up by "+ randHappiness);
                HttpContext.Session.SetString("Image", "~/images/happy.jpeg");

                return RedirectToAction("AfterActivity");
                }    

            }
            return RedirectToAction("AfterActivity");
        }

        [HttpPost("work")]
        public IActionResult Work()
        {
            Dachi myPet = HttpContext.Session.GetObjectFromJson<Dachi>("myPet");
            Random rand = new Random();
            int randMeals = rand.Next(1,4);
                
                if(myPet.Energy <= 0)
                {
                    HttpContext.Session.SetString("Message", "Out of Energy!");
                    HttpContext.Session.SetString("Image", "~/images/noOrdie.gif");
                    
                }
                else
                {
                    myPet.Energy -= 5;
                    myPet.Meals += randMeals;
                    HttpContext.Session.SetObjectAsJson("myPet", myPet);
                    HttpContext.Session.SetString("Message", "Keep it up! They just gained 5 Energy and " + randMeals + " Meals from working!" );
                    HttpContext.Session.SetString("Image", "~/images/happy.jpeg");


                    return RedirectToAction("AfterActivity");
                }
            return RedirectToAction("AfterActivity");
        }

        [HttpPost("sleep")]
        public IActionResult Sleep()
        {
            Dachi myPet = HttpContext.Session.GetObjectFromJson<Dachi>("myPet");

                myPet.Energy += 15;
                myPet.Fullness -= 5;
                myPet.Happiness -= 5;
                HttpContext.Session.SetObjectAsJson("myPet", myPet);
                HttpContext.Session.SetString("Message", "Comfy! Gained 15 Engergy but lost both Fullness and Happiness each by 5");    
                HttpContext.Session.SetString("Image", "~/images/sleep.png");
                return RedirectToAction("AfterActivity");
        }

        [HttpGet("win")]
        public IActionResult Win()
        {
            Dachi myPet = HttpContext.Session.GetObjectFromJson<Dachi>("myPet");
            ViewBag.message = "Congrats! You Won!";

            return View("Win", myPet);
        }

        [HttpGet("lose")]
        public IActionResult Lose()
        {
            Dachi myPet = HttpContext.Session.GetObjectFromJson<Dachi>("myPet");
            ViewBag.message = "Sorry, your pet died!";
            return View("Lose" , myPet);
        }

        [HttpGet("restart")]
        public IActionResult Restart()
        {
            // HttpContext.Session.Clear();// don't need to clear Session
            return RedirectToAction("Home");
        }
    }


}