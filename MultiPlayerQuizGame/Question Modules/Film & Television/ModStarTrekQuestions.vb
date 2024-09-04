Imports MultiPlayerQuizGame.ClsDataStructures

Module ModStarTrekQuestions

    Public Sub StarTrekQuestions()

        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What was the name of the first Star Trek series?",
              .Options = New String() {"Star Trek: Deep Space Nine", "Star Trek: The Next Generation", "Star Trek: Enterprise", "Star Trek: The Original Series"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who was the captain of the USS Enterprise in the original series?",
              .Options = New String() {"Jean-Luc Picard", "James T. Kirk", "Benjamin Sisko", "Jonathan Archer"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which species is known for their phrase ""Resistance is futile""?",
              .Options = New String() {"Klingons", "Romulans", "Borg", "Ferengi"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "In Star Trek: The Next Generation, who is the android serving as Chief Operations Officer?",
              .Options = New String() {"Geordi La Forge", "Wesley Crusher", "Data", "Worf"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the first Klingon to serve in Starfleet?",
              .Options = New String() {"Martok", "Worf", "Gowron", "Kor"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek series features a space station rather than a starship?",
              .Options = New String() {"Star Trek: Voyager", "Star Trek: Deep Space Nine", "Star Trek: The Next Generation", "Star Trek: Enterprise"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of Spock’s father?",
              .Options = New String() {"Sarek", "Surak", "Sybok", "Shran"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which planet is the homeworld of the Vulcans?",
              .Options = New String() {"Romulus", "Vulcan", "Bajor", "Qo'noS"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "In Star Trek: Voyager, who is the captain of the USS Voyager?",
              .Options = New String() {"Kathryn Janeway", "Chakotay", "Tom Paris", "B'Elanna Torres"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the Prime Directive in Starfleet?",
              .Options = New String() {"To seek out new life", "To boldly go where no one has gone before", "Non-interference with pre-warp civilizations", "To protect Earth at all costs"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who is the bartender at Quark’s Bar on Deep Space Nine?",
              .Options = New String() {"Rom", "Morn", "Quark", "Nog"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek series introduced the character Seven of Nine?",
              .Options = New String() {"Star Trek: The Original Series", "Star Trek: Deep Space Nine", "Star Trek: The Next Generation", "Star Trek: Voyager"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the Klingon homeworld?",
              .Options = New String() {"Risa", "Kronos (Qo'noS)", "Romulus", "Andoria"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who was the first officer under Captain Kirk in the original series?",
              .Options = New String() {"Spock", "Scotty", "Uhura", "Sulu"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which species did Captain Kirk often confront in the original series?",
              .Options = New String() {"Cardassians", "Borg", "Romulans", "Ferengi"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who is the doctor aboard the USS Enterprise in Star Trek: The Next Generation?",
              .Options = New String() {"Dr. McCoy", "Dr. Bashir", "Dr. Crusher", "Dr. Phlox"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "In which quadrant of the galaxy is the Delta Quadrant?",
              .Options = New String() {"Alpha", "Beta", "Gamma", "Delta"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the holographic doctor in Star Trek: Voyager?",
              .Options = New String() {"Zimmerman", "The Doctor", "Data", "Paris"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character was known for saying ""Make it so""?",
              .Options = New String() {"Captain Kirk", "Captain Picard", "Captain Janeway", "Captain Sisko"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who is the chief engineer of the USS Enterprise in the original series?",
              .Options = New String() {"Scotty", "Geordi La Forge", "O’Brien", "Trip Tucker"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek movie features the first appearance of the Borg?",
              .Options = New String() {"Star Trek: First Contact", "Star Trek: The Wrath of Khan", "Star Trek: Generations", "Star Trek: Nemesis"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of Worf's son?",
              .Options = New String() {"Alexander", "Kurn", "Martok", "Gowron"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which race was known for their shapeshifting abilities in Deep Space Nine?",
              .Options = New String() {"Romulans", "Founders (Changelings)", "Ferengi", "Bajorans"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "In Star Trek: The Next Generation, what is the name of Picard's starship?",
              .Options = New String() {"USS Defiant", "USS Voyager", "USS Enterprise-D", "USS Prometheus"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which alien species did Captain Kirk fight in the famous ""Arena"" episode?",
              .Options = New String() {"Borg", "Gorn", "Romulans", "Tholians"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who played the role of Spock in the original series?",
              .Options = New String() {"William Shatner", "DeForest Kelley", "Leonard Nimoy", "James Doohan"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the first starship to bear the name Enterprise?",
              .Options = New String() {"NX-01", "NCC-1701", "NCC-1701-D", "NCC-74656"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who was the first captain of the USS Enterprise in Star Trek: Enterprise?",
              .Options = New String() {"Christopher Pike", "Jonathan Archer", "James T. Kirk", "Robert April"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek series is set furthest in the future?",
              .Options = New String() {"Star Trek: The Original Series", "Star Trek: The Next Generation", "Star Trek: Discovery", "Star Trek: Picard"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character in Star Trek: Voyager is a former Borg drone?",
              .Options = New String() {"Tuvok", "B'Elanna Torres", "Chakotay", "Seven of Nine"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "In Deep Space Nine, what is the name of the wormhole near the station?",
              .Options = New String() {"The Gamma Wormhole", "The Bajoran Wormhole", "The Delta Wormhole", "The Alpha Wormhole"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who is the primary antagonist in Star Trek II: The Wrath of Khan?",
              .Options = New String() {"Q", "Khan Noonien Singh", "The Borg Queen", "Gul Dukat"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character said ""Live long and prosper""?",
              .Options = New String() {"Captain Kirk", "Spock", "Data", "Sarek"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek captain was played by Kate Mulgrew?",
              .Options = New String() {"Captain Janeway", "Captain Picard", "Captain Archer", "Captain Sisko"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the registry number of the USS Enterprise in the original series?",
              .Options = New String() {"NCC-74656", "NCC-1701", "NX-74205", "NCC-2106"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which alien species did Captain Kirk often ally with against the Klingons?",
              .Options = New String() {"Ferengi", "Bajorans", "Romulans", "Hirogen"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who played Captain Picard in Star Trek: The Next Generation?",
              .Options = New String() {"William Shatner", "Avery Brooks", "Patrick Stewart", "Scott Bakula"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which ship did Commander Sisko take command of during the Dominion War?",
              .Options = New String() {"USS Voyager", "USS Defiant", "USS Excelsior", "USS Enterprise-D"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the telepathic bartender on the USS Enterprise-D?",
              .Options = New String() {"Tasha Yar", "Deanna Troi", "Guinan", "Ro Laren"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which alien race was known for their warlike nature and honor-bound society?",
              .Options = New String() {"Romulans", "Cardassians", "Klingons", "Vulcans"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who was the chief medical officer on Star Trek: Deep Space Nine?",
              .Options = New String() {"Dr. Bashir", "Dr. Crusher", "The Doctor", "Dr. Phlox"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the enemy race that sought to conquer the galaxy in Star Trek: Enterprise?",
              .Options = New String() {"Romulans", "Xindi", "Kazon", "Hirogen"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek series was the first to feature a female captain as the main character?",
              .Options = New String() {"Star Trek: The Next Generation", "Star Trek: Deep Space Nine", "Star Trek: Voyager", "Star Trek: Discovery"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which ship was commanded by Captain Christopher Pike?",
              .Options = New String() {"USS Defiant", "USS Voyager", "USS Enterprise", "USS Prometheus"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the Vulcan officer in Star Trek: Enterprise?",
              .Options = New String() {"T’Pol", "Saavik", "Valeris", "Soval"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who was the main villain in Star Trek: First Contact?",
              .Options = New String() {"Khan Noonien Singh", "The Borg Queen", "Q", "Locutus"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which alien race is known for their large ears and love of profit?",
              .Options = New String() {"Romulans", "Klingons", "Ferengi", "Bajorans"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What was the name of the first Ferengi to serve in Starfleet?",
              .Options = New String() {"Quark", "Rom", "Nog", "Zek"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who was the original chief engineer aboard the USS Enterprise-D?",
              .Options = New String() {"Geordi La Forge", "Tasha Yar", "Miles O'Brien", "Data"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What was the first Star Trek series to air in the 21st century?",
              .Options = New String() {"Star Trek: Voyager", "Star Trek: Enterprise", "Star Trek: Discovery", "Star Trek: Picard"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the species that Neelix belongs to in Star Trek: Voyager?",
              .Options = New String() {"Talaxian", "Ocampa", "Kazon", "Vorta"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which captain was assimilated by the Borg and became known as Locutus?",
              .Options = New String() {"Captain Kirk", "Captain Sisko", "Captain Janeway", "Captain Picard"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What was the name of the first officer aboard the USS Voyager?",
              .Options = New String() {"Tuvok", "Chakotay", "Paris", "Seven of Nine"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which alien species was known for their ruthless military and secretive society in Deep Space Nine?",
              .Options = New String() {"Klingons", "Cardassians", "Romulans", "Ferengi"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek series introduced the concept of the Mirror Universe?",
              .Options = New String() {"Star Trek: The Original Series", "Star Trek: Deep Space Nine", "Star Trek: Enterprise", "Star Trek: Discovery"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character in Star Trek: The Next Generation was a Klingon raised by humans?",
              .Options = New String() {"Kurn", "Worf", "Gowron", "Martok"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the ship that Captain Archer commands in Star Trek: Enterprise?",
              .Options = New String() {"USS Enterprise-D", "USS Defiant", "USS Voyager", "USS Enterprise NX-01"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who is the Bajoran first officer in Star Trek: Deep Space Nine?",
              .Options = New String() {"Dax", "Kira Nerys", "Quark", "Odo"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which species from the Delta Quadrant did the Voyager crew frequently encounter?",
              .Options = New String() {"Klingons", "Romulans", "Kazon", "Andorians"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which captain broke the Prime Directive to save an alien civilization from extinction?",
              .Options = New String() {"Captain Picard", "Captain Kirk", "Captain Janeway", "Captain Sisko"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the planet that is home to the Cardassians?",
              .Options = New String() {"Romulus", "Cardassia Prime", "Bajor", "Ferenginar"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which species did the Dominion ally with during the Dominion War?",
              .Options = New String() {"Vulcans", "Cardassians", "Klingons", "Romulans"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek series featured a starship lost in the Delta Quadrant?",
              .Options = New String() {"Star Trek: The Next Generation", "Star Trek: Deep Space Nine", "Star Trek: Voyager", "Star Trek: Enterprise"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek series introduced the Borg?",
              .Options = New String() {"Star Trek: The Original Series", "Star Trek: Deep Space Nine", "Star Trek: The Next Generation", "Star Trek: Voyager"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek series is set before the events of the original series?",
              .Options = New String() {"Star Trek: The Next Generation", "Star Trek: Deep Space Nine", "Star Trek: Voyager", "Star Trek: Enterprise"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character was chief of security on the USS Enterprise-D?",
              .Options = New String() {"Worf", "Data", "Geordi La Forge", "Beverly Crusher"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who played the role of Captain Janeway in Star Trek: Voyager?",
              .Options = New String() {"Jeri Ryan", "Kate Mulgrew", "Marina Sirtis", "Nana Visitor"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which ship is known as the flagship of the Federation?",
              .Options = New String() {"USS Voyager", "USS Enterprise", "USS Defiant", "USS Prometheus"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of Data’s pet cat in Star Trek: The Next Generation?",
              .Options = New String() {"Spot", "Porthos", "Isis", "Neelix"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the planet where James T. Kirk was born?",
              .Options = New String() {"Earth", "Vulcan", "Qo'noS", "Iowa, on Earth"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which race is known for their blue skin and antennae?",
              .Options = New String() {"Andorians", "Betazoids", "Bajorans", "Ferengi"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the Klingon homeworld?",
              .Options = New String() {"Romulus", "Qo'noS", "Vulcan", "Bajor"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who served as the tactical officer on the USS Enterprise-D?",
              .Options = New String() {"Data", "Worf", "Riker", "Geordi La Forge"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "In Star Trek: The Next Generation, who was the original chief engineer?",
              .Options = New String() {"Worf", "Data", "Miles O'Brien", "Tasha Yar"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which species was known for their great intelligence and long life?",
              .Options = New String() {"Vulcans", "Klingons", "Ferengi", "Bajorans"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character was a Cardassian tailor on Deep Space Nine?",
              .Options = New String() {"Dukat", "Garak", "Odo", "Nog"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who was the science officer aboard the USS Enterprise in the original series?",
              .Options = New String() {"Scotty", "Spock", "McCoy", "Sulu"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What was the name of the starship that encountered the Borg in Star Trek: The Next Generation?",
              .Options = New String() {"USS Defiant", "USS Enterprise-D", "USS Voyager", "USS Excelsior"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character was the ship’s counselor on the USS Enterprise-D?",
              .Options = New String() {"Beverly Crusher", "Deanna Troi", "Guinan", "Ro Laren"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which species was known for their strict adherence to logic?",
              .Options = New String() {"Vulcans", "Klingons", "Romulans", "Ferengi"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who was the captain of the USS Defiant in Deep Space Nine?",
              .Options = New String() {"Captain Janeway", "Captain Picard", "Captain Sisko", "Captain Archer"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek movie involves time travel to save Earth’s whales?",
              .Options = New String() {"Star Trek: The Wrath of Khan", "Star Trek: The Voyage Home", "Star Trek: First Contact", "Star Trek: Nemesis"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character is known for their fondness for Klingon opera?",
              .Options = New String() {"Worf", "Data", "Riker", "Sulu"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which species did the Federation fight in the Dominion War?",
              .Options = New String() {"Romulans", "Dominion", "Borg", "Klingons"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character in Star Trek: Voyager was a former Maquis officer?",
              .Options = New String() {"Tuvok", "B'Elanna Torres", "The Doctor", "Neelix"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek captain was played by Scott Bakula?",
              .Options = New String() {"Captain Archer", "Captain Kirk", "Captain Picard", "Captain Janeway"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who was the captain of the USS Excelsior?",
              .Options = New String() {"Captain Sulu", "Captain Kirk", "Captain Janeway", "Captain Archer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the Cardassian military leader who became the primary antagonist in Deep Space Nine?",
              .Options = New String() {"Garak", "Dukat", "Nog", "Rom"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What is the name of the Federation’s greatest enemy in the Star Trek: The Next Generation era?",
              .Options = New String() {"Klingons", "Romulans", "Cardassians", "Borg"}, .CorrectAnswer = 3})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "What species is Odo from Deep Space Nine?",
              .Options = New String() {"Bajoran", "Founder", "Klingon", "Romulan"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek series is set on a starship trying to return home after being stranded far from Earth?",
              .Options = New String() {"Star Trek: The Next Generation", "Star Trek: Deep Space Nine", "Star Trek: Voyager", "Star Trek: Enterprise"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character is known for the catchphrase ""I’m a doctor, not a…""?",
              .Options = New String() {"Dr. Crusher", "The Doctor", "Dr. McCoy", "Dr. Phlox"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which species is known for their long-standing rivalry with the Federation?",
              .Options = New String() {"Klingons", "Bajorans", "Cardassians", "Ferengi"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Who was the helmsman of the USS Enterprise in the original series?",
              .Options = New String() {"Spock", "Chekov", "Sulu", "Uhura"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which race enslaved the Bajorans in Deep Space Nine?",
              .Options = New String() {"Romulans", "Cardassians", "Ferengi", "Klingons"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek captain had a love of archaeology?",
              .Options = New String() {"Captain Picard", "Captain Kirk", "Captain Janeway", "Captain Archer"}, .CorrectAnswer = 0})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek series featured the character Dr. Phlox?",
              .Options = New String() {"Star Trek: The Next Generation", "Star Trek: Voyager", "Star Trek: Enterprise", "Star Trek: Discovery"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which Star Trek movie featured the line ""The needs of the many outweigh the needs of the few""?",
              .Options = New String() {"Star Trek: The Motion Picture", "Star Trek II: The Wrath of Khan", "Star Trek: First Contact", "Star Trek: Nemesis"}, .CorrectAnswer = 1})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which character was known for playing poker with the senior officers on the USS Enterprise-D?",
              .Options = New String() {"Captain Picard", "Geordi La Forge", "Data", "Worf"}, .CorrectAnswer = 2})
        Questions.Add(New Question With {.Category = "Star Trek", .Text = "Which alien species did Captain Kirk meet in the episode ""The Devil in the Dark""?",
              .Options = New String() {"Gorn", "Horta", "Romulans", "Ferengi"}, .CorrectAnswer = 1})

    End Sub
End Module
