﻿using System;

public class Program
{
    public static void Main()
    {
        string[] palindromes =
        {   "0",
            "1",
            "3",
            "5",
            "7",
            "9",
            "33",
            "99",
            "313",
            "585",
            "717",
            "7447",
            "9009",
            "15351",
            "32223",
            "39993",
            "53235",
            "53835",
            "73737",
            "585585",
            "1758571",
            "1934391",
            "1979791",
            "3129213",
            "5071705",
            "5259525",
            "5841485",
            "13500531",
            "719848917",
            "910373019",
            "939474939",
            "1290880921",
            "7451111547",
            "10050905001",
            "18462126481",
            "32479297423",
            "75015151057",
            "110948849011",
            "136525525631",
            "1234104014321",
            "1413899983141",
            "1474922294741",
            "1792704072971",
            "1794096904971",
            "1999925299991",
            "5652622262565",
            "7227526257227",
            "7284717174827",
            "9484874784849",
            "34141388314143",
            "552212535212255",
            "933138363831339",
            "1793770770773971",
            "3148955775598413",
            "10457587478575401",
            "10819671917691801",
            "18279440804497281",
            "34104482028440143",
            "37078796869787073",
            "37629927072992673",
            "55952637073625955",
            "161206152251602161",
            "313558153351855313",
            "7036267126217626307",
            "9674868723278684769",
            "10879740244204797801",
            "32889941788714998823",
            "94778157422475187749",
            "114354126121621453411",
            "539475328171823574935",
            "17461998948684989916471",
            "72928088195859188082927",
            "92913401775957710431929",
            "94261805583838550816249",
            "1130486074817184706840311",
            "1194313761393931673134911",
            "1219228158701078518229121",
            "5812988563013103658892185",
            "7260988688520258868890627",
            "7475703079870789703075747",
            "50824513851188115831542805",
            "138758321383797383123857831",
            "351095331428353824133590153",
            "390714505091666190505417093",
            "532079161251434152161970235",
            "552963956270141072659369255",
            "795280629691202196926082597",
            "1609061098335005338901609061",
            "17869806142184248124160896871",
            "19756291244127372144219265791",
            "30000258151173237115185200003",
            "30658464822225352222846485603",
            "56532345659072227095654323565",
            "378059787464677776464787950873",
            "1115792035060833380605302975111",
            "3390741646331381831336461470933",
            "7155681676104835384016761865517",
            "188726493036450333054630394627881",
            "332997156422555464555224651799233",
            "579782100975917393719579001287975",
            "1409460884147943003497414880649041",
            "1480869563960100770010693659680841",
            "9932525402284695775964822045252399",
            "10652099006552766666725560099025601",
            "10827628430039640604693003482672801",
            "54074940541725088788052714504947045",
            "76759778311938325452383911387795767",
            "94285848717805140304150871784858249",
            "96754720977532710701723577902745769",
            "139124355701640720027046107553421931",
            "710084230446469950059964644032480017",
            "794397832642722540045227246238793497",
            "998021119318189842248981813911120899",
            "1323475457008895965695988007545743231",
            "1681824725831390428240931385274281861",
            "5893890080115984244424895110800983985",
            "9707999142717984907094897172419997079",
            "9970387454991896491946981994547830799",
            "32190158233101105022050110133285109123 ",
            "122240824002234545959545432200428042221",
            "124192421350471300727003174053124291421",
            "131674457014330218696812033410754476131",
            "551700061998405245575542504899160007155",
            "773609618198307097595790703891816906377 ",
            "1017421766189445102992015449816671247101",
            "1634587141488515712882175158841417854361",
            "7114907950920173924554293710290597094117",
            "14327425216354951264146215945361252472341",
            "31636759764024794204540249742046795763613"
        };

        for (int i = 0; i < 129; i++)
        {
            Console.WriteLine("{0}", palindromes[i]);

        }
    }
}