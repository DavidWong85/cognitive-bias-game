VAR ask = 0
Sameer is driving his way back home. Suddenly, a loud noise popped, and the car slowed down and stopped.
Sammer gets off the car.
What should he do:
->LeaveCar
===LeaveCar===
*[Check the car]
Sammer checked his car and found the tires were flat. 'Why did this have to happen in this blasted valley?' Sameer said aloud, though there was no one else standing nearby. 
->LeaveCar
*[Look around]
Sammer looked around. The tall Welsh mountains that towered all around him were covered with snow.
->LeaveCar
*[Look at his watch]
Sammer looked at his watch. It was two-thirty in the afternoon. The sun would start going down soon, and if he didn't get help in the next hour or so, he was done for.
->LeaveCar
*[Call for help]
Sammer tried calling the breakdown service's emergency help number. Call Failed, his mobile repeated.
->LeaveCar
*->
There was nothing to be done. Other than to put on the thick woollen overcoat, lock the car and walk down the road. With luck, he would be able to find a house which had people in it.
Thankfully it had stopped snowing, even though a bitterly cold wind continued to bite into his exposed face.
Sammer was not an outdoorsman. In fact, he hated any work which required him to step out of his bank's glass-panelled offices.
However, this was a job which he could not delegate to a subordinate. The client, a very valuable and old one, had insisted that Sameer give the adventure park tucked away in Snowdonia a personal once-over before he put his money in it.
Sameer had been unable to say No. He had grown up in Liverpool, which was actually not too far from northern Wales, where he currently was.
But he had put all that behind him. His clipped Oxbridge accent did not have the slightest trace of Scouse, and the days of hardship after his parents came to the UK from Uganda were a distant memory.
After he had walked five minutes, he: 
->Walked5min
===Walked5min===
*[Look around]
Sameer looked around him. He could see a large flock of sheep in the distance, but there was no sign of human habitation.
->Walked5min
*[Chek his phone]
Sameer checked his mobile yet again. No, there was no signal.
He climbed onto a large stone and looked at his mobile, hoping the elevation would make a difference. It didn't.
One would have thought the British government would have found a way of ensuring every nook and corner of this great island had mobile signal coverage!
->Walked5min
*->
He continued to walk along the road.
Another ten minutes later, Sameer suddenly came upon a house. It was tucked away into an alcove and was invisible until one came upon it.
It was a small house with a neat garden in front and wooden railings all around it. A sign on the gate said, "Piano Lessons Given By Experienced Teacher".
->DiscoverHouse
===DiscoverHouse===
Sameer stood outside the wicket gate and shouted, 'anybody inside?'
There was no response. 'Hello there! Anybody inside?' Sameer bellowed louder.
Sameer shuddered with frustration. He could already sense the sun's rays mellowing, ready to disappear. The winter solstice was just a week away.
He would now have to open the wicket gate, which was held in place by a lever, and pass through the garden to reach the house's front door.
I hope to God there's no dog, Sameer muttered to himself.
But whoever had heard of a Welsh household without a dog?
Sameer slowly opened the gate and walked in, expecting to be pounced upon by a sheepdog at any moment.
Was it his imagination, or could he hear the faint strains of a piano?
As he approached the door, a dog barked. Thank God the dog was inside the house rather than outside it. And yes, someone was definitely playing the piano.
'Hello! Anyone home?' Sameer rapped on the door a few times till he saw a bell hanging a few metres away.
He was about to ring it when the piano stopped playing.
*[Wait]
Sameer decided to wait.
*[Ring the bell]
Sameer rang the bell anyway.
-A few moments later, the door opened, and a woman peeped out, a large dog beside her.
Why did it have to be a woman? Sameer asked himself.
If it were a man, there was a much better chance of receiving some help.
I hope to God this woman does not turn out to be one of those dour and unhelpful ones, he told himself.
Was this the piano teacher? Sameer wondered.
It must be since the piano was no longer playing.
'Can I help you?' the woman asked him in a quiet voice which suggested that she would be anything but helpful.
She was quite well dressed for a village woman and was in fact good looking.
But the rather blank look in her eyes did not suggest a helpful attitude to humanity in general.
Sameer had come across millions of women like this one. They would never miss a please or a thank you or fail to hold open the door for you.
But when it came to doing a real favour, they would back away. Oh! Did he know such women?
Most of his female colleagues were of that sort.
->AskWomen
===AskWomen===
*{ask == 0} [Ask for help politely]
'Yes, Hi! I'm Sam. Sam from London.'
He had been Sam ever since he came to the UK and started school in Liverpool at the age of ten.
Sameer gave the women his standard smile, the one he always gave the bank's customers.
It was an effective smile, one without the least hint of plastic or anything else artificial.
'Hello, Sam!' The woman responded.
'My car broke down and, and... there doesn't seem to be any mobile coverage out here. I was wondering if...'
The woman did not let him complete. 'If you were to continue walking, you'll come to a phone booth and...'
~ ask += 1
->AskWomen
*{ask == 1} [Request to use landline]
'Can I please come inside your home and make a single phone call?' Sameer asked her, his anger showing in his voice.
Oh, for Chrissake, was he going to attack her if she allowed him inside? Not with a dog next to her!
'If you were to continue walking, you'll find a phone booth. And that's not more than five minutes away.' The woman's voice was firm and insistent.
Sameer stood where he was.
This was incredulous. 
He was a banker, it was freezing, the sun was about to set, and the woman expected him to walk in the snow for five more minutes!
~ ask += 1
->AskWomen
*{ask == 2} [Request to use landline again]
'I'd be happy to pay you for the privilege for making a call from your landline.'
'I'm so very sorry. But I'm alone in the house and... there's a phone booth not too far away.' Saying that the woman actually shut the door in his face.
->AskWomen
*->
Sameer slowly walked out of the compound.
Would that woman have treated him thus if he were white?
No, she wouldn't have. No way, No.
There was no choice but to do what that blasted woman suggested and walk for another five minutes.
->END