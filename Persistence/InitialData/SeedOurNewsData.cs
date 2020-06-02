using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.InitialData
{
    public class SeedOurNewsData
    {

        public static async Task SeedData(DataContext context)
        {
            if(!context.Articles.Any())
            {
                var news = new List<Article>
                {
                    new Article
                    {
                        Author = "Joshua Learn",
                        Category = "Science",
                        Level = 1,
                        DatePublished = new DateTime(2020, 5, 27),
                        Title = "Fossil Bite Marks Show Some Dinosaurs Ate Their Own",
                        Description = "Prehistoric remains also reveal signs of a particularly large predator.",
                        Content = " Some 152 million years ago, the Mygatt-Moore Quarry that now sits in present day western Colorado was as good a place to die as any for a dinosaur. " +
                        "Whether the creatures whose remains litter the site were killed by predators or died of old age or sickness is unclear, but we now know that many of the dinos that breathed their last breath at Mygatt-Moore were eaten. " +
                        "Some were likely even cannibalized.",
                        MainContent = "“It would take a while for these things to be buried,” said Stephanie Drumheller-Horton, a paleontologist at the University of Tennessee, in Knoxville. “There were an awful lot of jokes about what this place smelled like.”" + "The fossil bones at the quarry mostly belong to massive plant-eating sauropods and carnivorous theropods that lived during the Jurassic period. The most common species found is Allosaurus fragilis, a prehistoric predator around 30 feet long with powerful arms and large claws and teeth that likely roamed in herds." +
                                      "Most paleontologists and fossil hunters focus on the beautiful intact remains that have survived the eons. But many of the famous dinosaur deposits around the world are also filled with a number of oft-overlooked fossilized bone fragments. Drumheller-Horton and her colleagues were keen to take a closer look at this “bunch of ugly, beat-up fossils, which are my favorite kind in the whole world,” she said." +
                                      "While the intact skeletons of whole dinosaurs steal the show in museums or on science documentaries, they usually reveal little about ancient ecology. Most of these dinosaurs died as victims of natural disasters such as mudslides that quickly buried them, leaving their remains relatively pristine. Unless smaller fossilized bones representing a last meal are preserved in one animal's stomach, it’s difficult to say what they ate, or what ate them. Meanwhile, studying broken bones with bite marks, as Drumheller-Horton and her co-authors did in a study published today in the journal PLOS ONE, can tell us more about who was eating whom."+
                                      "“This kind of study can get us a lot of information about what the environment was like, how these animals were living, how they were dying, how nutrients cycled through these environments,” Drumheller-Horton said."+
                                      "The paleontologists analyzed 2,368 vertebrate fossils collected over decades of excavations from Mygatt-Moore. The fossils were found in the Morrison Formation, a layer of sedimentary rock from the Upper Jurassic that has proved one of the richest sources of dino fossils in North America. Of the thousands examined, 684 had bite marks -- some 28.9 percent."+
                                      "“We just started finding literally hundreds of bite marks, which is a bit of a surprise to us,” Drumheller-Horton said, adding that due to the paucity of this type of evidence in fossils, some researchers had assumed that dinosaurs were more like modern day Komodo dragons, which often target soft tissues and leave bones alone."+
                                      "To better understand the bite marks they found, the team classified them into dents, punctures, scores and other types."+
                                      "It’s difficult to tell what creatures were responsible for many of the bites.But a number of the marks indicated they were made from striated, saw - like teeth that matched the size of the teeth of the two largest predators known from the area, Allosaurus and Ceratosaurus.The researchers even found the marks of a “substantially larger” predator that could have been either an uncharacteristically large Allosaurus or something usually found in other Morrison Formation fossil assemblages, such as Saurophaganax or Torvosaurus."+
                                      "They found that sauropods represented 70 % of the remains with bite marks, while therapods like Allosaurus represented 17 %.Many of the latter were also found with bite marks that had striations, making it likely that they were cannibalizing their own species."+
                                      "“To the best of our knowledge, this is the best evidence for it in Allosaurus,” Drumheller - Horton said, adding that cannibalism is relatively common in many modern predators as well."+
                                      "Drumheller - Horton and her colleagues believe that the high number of bite marks on bones may show the area experienced droughts or other trying times that made bone - gnawing more common.But they are also careful to say that the quantity of bite marks may not be abnormal-- it could be just that most paleontologists don’t focus on these types of remains."+
                                      "Gregory Erickson, a dinosaur paleobiologist at Florida State University in Tallahassee who was not involved in Drumheller - Horton’s study, likes the way the research was conducted, calling it “well - balanced.” Andre Rowe, a Ph.D.candidate in paleontology at the University of Bristol in the U.K., who was also not involved in the recent study, said more of these types of investigations should be done."+
                                      "“There’s all kinds of tiny clues in the rocks that people tend to gloss over in favor of the big attractive bones,” Rowe said."+
                                      "Drumheller - Horton said the team still can’t tell whether the dinosaurs died from the bites or whether their bodies were just scavenged, but she said both were probably occurring.She envisions that carcasses at the site would attract a succession of scavengers similar to what would happen with lions, hyenas and vultures in the modern - day African savanna.Deaths may have even occurred while two Allosaurus were fighting over prey, with the losing side subsequently getting eaten itself."+
                                      "Rowe said the study adds to evidence that categorizing dinosaurs by their eating habits isn’t always the easiest."+
                                      "He said most predators, extinct and living today, often use a mixture of hunting and scavenging."+
                                      "Erickson agrees. “Most carnivorous animals are lazy.If it’s dead and it’s made out of meat, then let’s eat,” he joked.",
                        MainPhoto = "image1.jpg",
                        SecundaryPhoto = "",
                        Tags = "Evolution, Dinosauros"
                    },
                     new Article
                    {
                        Author = "Chris Gorski",
                        Category = "Technology",
                        Level = 1,
                        DatePublished = new DateTime(2020, 3, 3),
                        Title = "A Linguistic Lens on Artificial Intelligence",
                        Description = "A conversation with computational linguist Emily M. Bender about the ways artificial intelligence can go wrong.",
                        Content = "Automatic speech recognition is an important technology for many people. They ask Alexa to play them music or Siri to call their mother. Sometimes the technology doesn't understand the users or provide the answers they want. With some technologies, that's because artificial intelligence just isn't as adaptable and responsive as an actual human. With others, there can be unintended biases within either the data used to train the technology or the software's interpretation of the data. And sometimes, the weaknesses of the technology aren't immediately obvious.",
                        MainContent = "So when computational linguist Emily M. Bender from the University of Washington in Seattle spoke with Inside Science's Chris Gorski earlier this month at a meeting of the American Association for the Advancement of Science in Seattle, there was a lot to talk about. " +
                        "The conversation below, which has been edited and condensed for clarity and brevity, began with introductions and then quickly moved into a pretty meta place. That's where the text below begins.Emily M. Bender: Once you turned on the recorder, both you and I changed a little bit how we're speaking -- we sort of said," +
                        "'Now we're doing the interview.' ... I might be doing it more than you and you might just be accommodating me, but these are sort of sociolinguistic facts.Chris Gorski, Inside Science: I'm certainly performing in some way anytime that I'm trying to learn more about what someone does."+
                        " Right.You're going to talk to me differently than you're going to talk to your friends, or even when you're talking to me about the subway or your kids because [an interview] is something different. We do that all without thinking about it. This weekend you were part of a group of researchers discussing the ethical risks of voice technology, which includes technologies like Alexa and Siri. In what ways can these efforts go wrong?"+
                        " If the sample [used to train the technology] isn't representative of the broad population, then it's not going to work as well for people who are not the ones who are represented.And what tends to happen is the people who speak the language variety that has been anointed the standard are the ones who are best represented. ... So if you design something that works only for people who have the privilege of being raised to speak the standard variety[of a language], " +
                        " and then deploy it in the world without thinking carefully about that, you could end up just exacerbating current inequities in society because life just gets that much harder for someone for whom that is not their own dialect. ... It's not that that variety of English is any harder for machines, it's just it's not the one that the machines have been trained on." +
                        " My nightmare is that someone's going to try to embed automatic speech recognition in the 911 response system. Everybody in the community needs to have access to 911 and that needs to be equitable. To my knowledge, no one's done this, it's just something that I worry about. But if you put a computer in the way there, then are you hampering people's access to emergency first responders." +
                        "It does happen now with things like trying to change your flights or reach your health insurance company. I just heard about a trans man who can no longer access his bank account, which is in another country, because, as part of his transition, he's done hormones that have changed his voice. The computer system of the bank is basically saying you're not the same person anymore." +
                        "Is this a new frontier that doesn't have laws? Can it be solved from the tech side by being more encouraging of diverse datasets, having people from all kinds of backgrounds? Or do we need laws plus all of the above? I'm not a lawyer, so I can't really tell if the old frameworks are just inadequate or we haven't learned how to apply the old frameworks. But what's new is something about" +
                        "scale, big data. The amount of information that can be gathered and processed --that's operating at a scale where you cannot go through and do quality control. The whole point is that it's so big you need a computer and so you can't go in and say, 'All right, what kind of garbage data should we avoid using?'",
                        MainPhoto = "image2.jpg",
                        SecundaryPhoto = "",
                        Tags = "Artificial Intelligence, Culture"
                    },
                     new Article
                    {
                        Author = "Catherine Meyers",
                        Category = "Physics",
                        Level = 1,
                        DatePublished = new DateTime(2020, 3, 20),
                        Title = "In Locked Down Spain, a Physicist's Disease Model Research Turns Strikingly Real",
                        Description = "Yamir Moreno studies how human networks spread COVID-19 and other diseases.",
                        Content = "Yamir Moreno is a physicist at the University of Zaragoza in Spain, where he is also director of the Institute for Biocomputation and Physics of Complex Systems. For about 20 years, he has applied the tools of physics to improve models of disease spread. He was among the pioneering researchers who first incorporated knowledge about humans’ contact networks and everyday movements to make epidemic models more realistic.",
                        MainContent = "Inside Science’s Catherine Meyers talked to Moreno on March 17, shortly after Spain had announced a countrywide lockdown in an effort to slow the spread of the new coronavirus. As of March 20, deaths from the disease in Spain exceed 1,000. The following interview has been edited for brevity and clarity. Catherine Meyers: How is the mood in Spain right now? Yamir Moreno: It seems people are taking this seriously.If you " +
                        "go on the streets, it's almost empty, there are only people going for essential work. It's too early to know how this will impact people psychologically. As time goes by, [these measures] could collapse from pressure.It's a complete breakdown of people’s normal routine. That's something we don't know yet. But up to now, people’s mood is okay. How severe are the restrictions? They are relatively severe. There is enforced teleworking. " +
                        "The university is completely closed. All restaurants, and places where people can gather are closed. Unless you have to go for work or supplies, or are returning home, you cannot be on the street, either in your car or walking.If you have a dog and you are a couple, only one is allowed to go with the dog outside.But there are still some places that are open, some factories that are still open.There are still some shops that are open, shops " +
                        "where you can buy bread, milk, these kinds of things.Supermarkets are open, of course. How have you had to adjust your own work? I am the director of my institute, so I still have to go from time to time to check that everything is okay. We have bio labs, and we are granting some access to a company that purifies proteins that are needed for this COVID - 19 test.This is one part of the institute that has to be working.The other part is related to high - " +
                        "performance computing.It's the minimum activity, the essential activity, and as the director of the institute I have to oversee these sorts of things. From a more personal point of view, I'm working from home. I have some teaching. I have to lecture online whenever possible and have remote interactions with the students. What sort of research are you doing on the spread of the new coronavirus and how has it changed as the epidemic progressed? At the very " +
                        "beginning we had time to make predictions, make forecasts. We started to study this in mid-January. But as you enter this explosive phase, where the number of cases grows exponentially, you also need to rush a lot to evaluate scenarios, to try to quantify the facts, the impacts of the measures being taken. For that, we don't usually have a lot of time. There are two approaches -- you can provide rough estimates, things like what you should expect to see if the measures are working. This is one thing. " +
                        "The other thing is to approach it not for this moment exactly, but as something that is more of a scenario assessment.You try different approaches, even if they will not apply now. This is some knowledge that you will have for the next one.Because there will be a next one. How might your research or research like it be used by health officials? A model is a model. You have to be clear with whomever you talk about what your assumptions are, and say, " +
                        "'Okay, under these assumptions, this is what I get.' Because sometimes these assumptions are not the same from one day to the next. If this is valid today, the next day it could not be. So, it's important to be honest with ourselves and say, " +
                        "'This is our model, these are the limitations of the model, these are my assumptions.' That's okay. Whoever makes the decisions should be in the capacity to judge whether this is important or not. We provide feedback, put everything on the table; the crisis unit should be able to pick up what is the best solution. What questions are you looking at right now? " +
                        "One set of important questions that might have some impact for the future if we move fast enough is: Given that I have adopted these measures, how long can I afford to keep them running? And then how should we, say, reconnect the system? How do I come back to the initial state, where everyone was working, everyone was moving freely? Should I do this slowly, should I do this when I reach a particular level of incidence? The problem is that we are dealing with humans. Everything is like exploring a landscape of " +
                        "possibilities for which you don't know the probabilities. I have to wait to see which one is more likely to happen, which one is not, and then try to narrow down the set of possibilities. And for that you need time that you don't have, because there are people dying.It's a problem that is really hard. I think no one knows the answer. Do you have any sense of how long this situation might last globally? First the peak was in China and Asia. Now it is moving to Europe. I think the peak in most of Europe will be around mid-April or so. " +
                        "Then it will be the Americas, not only the U.S., the whole of the Americas. A question becomes, once you pass the peak, if you open your borders, if you again allow in people from countries where the explosive phase is taking place, what happens? I think the most optimistic scenario is around two months[for strict social distancing rules]. There are some scenarios in which you could be in a loop that lasts five to six months.We can try to control it, we can try to coexist with this, but the virus will not be under control unless we develop new pharmacological treatments. " +
                        "With our models, we can advise the authorities how to minimize the impact, but it will not be gone unless new pharmacological interventions are in place. How did you get interested in epidemic modeling? My background is in statistical physics. I did my Ph.D. in fracture mechanics -- applying statistical models to the rupture of materials, earthquakes, this kind of thing. When I finished my Ph.D., I wanted to change a little bit, start to do new things.I was lucky enough at that time that this field of network epidemiology was starting. That was in 2000. " +
                        "I am curious and I like to move beyond the boundaries of different disciplines. Networked epidemiology is one thing that is long - lasting in my research. It is one example in which you can have a real impact in society and human life.",
                        MainPhoto = "image3.jpg",
                        SecundaryPhoto = "",
                        Tags = "Physics, Mathematics"
                    },
                     new Article
                    {
                        Author = "Joe Brennan, The Irish times",
                        Category = "Economy",
                        Level = 1,
                        DatePublished = new DateTime(2020, 5, 28),
                        Title = "Irish economy to contract by 12%, ESRI forecasts",
                        Description = "Think tank warns against ‘tapering’ Covid-19 payment as businesses gradually restart",
                        Content = " The Republic’s economy is on track to shrink by 12.4 per cent this year, marking the largest annual slump in its history, as the Covid-19 pandemic wreaks havoc on households, firms and government finances, according to the Economic and Social Research Institute (ESRI).",
                        MainContent = "The forecast, contained in ESRI’s summer economic commentary, is more pessimistic than the Government’s projection that gross domestic product (GDP) will fall 10.5 per cent this year. It is also starker than the 7.5-8 per cent contraction factored in by the country’s two " +
                        "main banks, Bank of Ireland and AIB, as they revealed earlier this month that they had started to set aside money to cover an expected fresh spike in bad loans. The ESRI’s baseline scenario, which sees a gradual easing of lockdown restrictions and Covid-19 unemployment and wage subsidy supports " +
                        "expiring as planned in June, also envisages the Government posting a budget deficit of €27 billion or 9 per cent of GDP this year. A so-called severe scenario, involving a second wave of infections and another lockdown in the final months of the year, would see the economy contracting by 17 per cent, " +
                        "with a benign case of the economy returning to normal in the fourth quarter resulting in the downturn coming to 8.6 per cent, it said. Speaking to reporters, ESRI research professor Kieran McQuinn warned against the “tapering” of the special weekly €350 Covid-19 pandemic unemployment payment in the coming months, " +
                        "particularly as the economy is only gradually being opened up.",
                        MainPhoto = "image4.jpg",
                        SecundaryPhoto = "",
                        Tags = "Economy, Business"
                    },
                    new Article
                    {
                        Author = "John Campbell, BBC",
                        Category = "Science",
                        DatePublished = new DateTime(2020, 5, 27),
                        Title = "Brexit: NI 'could access UK market and EU single market'",
                        Description = "The Brexit Deal could bring advantages to Northern Ireland, giving it access to both the UK market and the EU single market, Edwin Poots has suggested",
                        Content = "But any advantages would be dependent on minimising new checks between GB and NI, said the DUP agriculture minister.The DUP has been strongly opposed to the Brexit deal, saying it threatens the constitutional and economic integrity of the UK. The deal's transition period, agreed in October, ends in January.",
                        MainContent = "At that time, Northern Ireland will continue to follow EU rules on agricultural and manufactured goods, while the rest of the UK will not. Additionally, the whole of the UK will leave the EU's customs union, but Northern Ireland will continue to enforce the EU's customs code at its ports. " +
                        "This will mean some new processes and checks for goods entering Northern Ireland from the rest of the UK. Last week the UK government confirmed it would expand infrastructure at Northern Ireland's ports to carry out checks on animals and food products. " +
                        "It generally described a 'light-touch' approach to new checks and processes, though the detail will all have to be agreed with the EU. Mr Poots said agreeing on such an approach to checks would be key. 'It has the potential to get right down to around 1% of commercial vehicles that are entering NI, and in that case that wouldn't be particularly damaging to the economy. " +
                        "We would have the advantage of actually having access to the Single Market and to the UK market, and make NI an attractive place for inward investment. 'So we need to be very sure that we can actually maximise that advantage, whilst at the other side minimising the disadvantage.' Meanwhile the Stormont official responsible for Brexit issues says that agrifood inspection " +
                        "facilities will have to be expanded 'quite materially' as a result of the deal. The EU has strict rules on food products, requiring them to enter the single market through border control posts. That will apply to food products entering NI from GB. Andrew McCormick told MLAs that existing facilities at ports and airports would have to be scaled up.",
                        MainPhoto = "image5.jpg",
                        SecundaryPhoto = "image5-sec.jpg",
                        Tags = "Politics, Economy"
                    }
                   
                };

                context.Articles.AddRange(news);
                context.SaveChanges();
            }
        }
    }
}
