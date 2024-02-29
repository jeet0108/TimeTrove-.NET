import p1_img from "./p1_img.png";
import p2_img from "./p2_img.png";
import p3_img from "./p3_img.png";
import p4_img from "./p4_img.png";
import p5_img from "./p5_img.png";
import p6_img from "./p6_img.png";
import p7_img from "./p7_img.png";
import p8_img from "./p8_img.png";
import p9_img from "./p9_img.png";
import p10_img from "./p10_img.png";
import p11_img from "./p11_img.png";
import p12_img from "./p12_img.png";
import p13_img from "./p13_img.png";
import p14_img from "./p14_img.png";
import p15_img from "./p15_img.png";
import p16_img from "./p16_img.png";
import p17_img from "./p17_img.png";
import p18_img from "./p18_img.png";
import p19_img from "./p19_img.png";
import p20_img from "./p20_img.png";
import p21_img from "./p21_img.png";
import p22_img from "./p22_img.png";
import p23_img from "./p23_img.png";
import p24_img from "./p24_img.png";
import p25_img from "./p25_img.png";
import p26_img from "./p26_img.png";
import p27_img from "./p27_img.png";
import p28_img from "./p28_img.png";
import p29_img from "./p29_img.png";
import p30_img from "./p30_img.png";
import p31_img from "./p31_img.png";
import p32_img from "./p32_img.png";
import p33_img from "./p33_img.png";
import p34_img from "./p34_img.png";
import p35_img from "./p35_img.png";
import p36_img from "./p36_img.png";

let all_product = [
  {
    id: 1,
    name: "Small Edit Emerald Mesh",
    category: "women",
    image: p1_img,
    new_price: "16,999",
    old_price: "19,999",
  },
  {
    id: 2,
    name: "Small Edit Grey",
    category: "women",
    image: p2_img,
    new_price: "9,999",
    old_price: "13,999",
  },
  {
    id: 3,
    name: "DKNY Soho Three-Hand Nude Leather Watch",
    category: "women",
    image: p3_img,
    new_price: "19,999",
    old_price: "23,999",
  },
  {
    id: 4,
    name: "Serein Mid Two-Tone 18K Gold Diamond Dial Watch",
    category: "women",
    image: p4_img,
    new_price: "29,999",
    old_price: "33,999",
  },
  {
    id: 5,
    name: "Shinola Detrola Buckeye 43mm",
    category: "women",
    image: p5_img,
    new_price: "14,999",
    old_price: "17,999",
  },
  {
    id: 6,
    name: "Ladies Vivienne Westwood Kensington Watch",
    category: "women",
    image: p6_img,
    new_price: "9,999",
    old_price: "12,999",
  },
  {
    id: 7,
    name: "TAG HEUER FORMULA 1 GULF",
    category: "men",
    image: p7_img,
    new_price: "39,999",
    old_price: "43,999",
  },
  {
    id: 8,
    name: "CONSTELLATION SMALL SECONDS",
    category: "women",
    image: p8_img,
    new_price: "29,999",
    old_price: "33,999",
  },
  {
    id: 9,
    name: "MICHAEL KORS DYLAN BLACK SILICONE (QUARTZ)",
    category: "kid",
    image: p9_img,
    new_price: "3,999",
    old_price: "5,999",
  },
  {
    id: 10,
    name: "Garonne Kids KV32Q468 Kid Scout Watch",
    category: "kid",
    image: p10_img,
    new_price: "2,999",
    old_price: "4,999",
  },
  {
    id: 11,
    name: "Eone Bradley Classic Black Mesh",
    category: "men",
    image: p11_img,
    new_price: "16,999",
    old_price: "21,999",
  },
  {
    id: 12,
    name: "Waldhoff Multimatic Automatic Imperial Gold",
    category: "men",
    image: p12_img,
    new_price: "29,999",
    old_price: "33,999",
  },
  {
    id: 13,
    name: "Classique Day-Date Moon Phase",
    category: "men",
    image: p13_img,
    new_price: "19,999",
    old_price: "23,999",
  },
  {
    id: 14,
    name: "Archetype Blackhawk Automatic Calendar Sky Blue",
    category: "men",
    image: p14_img,
    new_price: "59,999",
    old_price: "64,999",
  },
  {
    id: 15,
    name: "ORIS Big Crown 80th Anniversary Edition 40mm Mens Watch",
    category: "men",
    image: p15_img,
    new_price: "79,999",
    old_price: "85,999",
  },
  {
    id: 16,
    name: "ACCUTRON Legacy 2SW7A001",
    category: "men",
    image: p16_img,
    new_price: "19,999",
    old_price: "25,999",
  },
  {
    id: 17,
    name: "Rolex DaytonaNEW RELEASE 2023 Daytona ICE BLUE BAGUETTE 126506A",
    category: "men",
    image: p17_img,
    new_price: "1,59,999",
    old_price: "1,79,999",
  },
  {
    id: 18,
    name: "Junghans max bill 041456202",
    category: "men",
    image: p18_img,
    new_price: "34,999",
    old_price: "45,999",
  },
  {
    id: 19,
    name: "Archetype Loyalist Automatic Silver Navy",
    category: "men",
    image: p19_img,
    new_price: "29,999",
    old_price: "33,999",
  },
  {
    id: 20,
    name: "Chopard L.U.C XPS Twist QF",
    category: "men",
    image: p20_img,
    new_price: "24,999",
    old_price: "35,999",
  },
  {
    id: 21,
    name: "Chopard Mille Miglia Classic Chronograph and Ethical Yellow Gold",
    category: "men",
    image: p21_img,
    new_price: "64,999",
    old_price: "85,999",
  },
  {
    id: 22,
    name: "AVI-8 Spitfire Type 300 Automatic Gunmetal Grey",
    category: "men",
    image: p22_img,
    new_price: "89,999",
    old_price: "1,01,999",
  },
  {
    id: 23,
    name: "AVI-8 Hawker Harrier II Matador Chronograph Black",
    category: "men",
    image: p23_img,
    new_price: "89,999",
    old_price: "99,999",
  },
  {
    id: 24,
    name: "Szanto Desert Sands Antique Gold Ivory Brown",
    category: "men",
    image: p24_img,
    new_price: "14,999",
    old_price: "19,999",
  },
  {
    id: 25,
    name: "PASNEW Kids Watch Girls Analogue Classic Quartz",
    category: "kid",
    image: p25_img,
    new_price: "2,999",
    old_price: "4,999",
  },
  {
    id: 26,
    name: "Richard Mille RM 38-02 Tourbillon Bubba Watson",
    category: "kid",
    image: p26_img,
    new_price: "2,999",
    old_price: "4,999",
  },
  {
    id: 27,
    name: "Richard Mille RM 35-02 Automatic Rafael Nadal Red Men’s Watch",
    category: "kid",
    image: p27_img,
    new_price: "2,999",
    old_price: "4,999",
  },
  {
    id: 28,
    name: "Garonne Kids KV31Q467 Kid Scout Watch",
    category: "kid",
    image: p28_img,
    new_price: "2,999",
    old_price: "3,999",
  },
  {
    id: 29,
    name: "Garonne Kids KQ29Q470 Water Stripes Watch",
    category: "kid",
    image: p29_img,
    new_price: "3,999",
    old_price: "4,999",
  },
  {
    id: 30,
    name: "Festina F20345/2 Junior Watch",
    category: "kid",
    image: p30_img,
    new_price: "6,999",
    old_price: "9,999",
  },
  {
    id: 31,
    name: "Casio Vintage LA670WEA-7EF Vintage Mini Watch",
    category: "kid",
    image: p31_img,
    new_price: "4,999",
    old_price: "8,999",
  },
  {
    id: 32,
    name: "Garonne Kids KV22Q468 Kid Scout Watch",
    category: "kid",
    image: p32_img,
    new_price: "2,999",
    old_price: "3,999",
  },
  {
    id: 33,
    name: "Timex Time Machines Digital 35mm Watch",
    category: "kid",
    image: p33_img,
    new_price: "1,999",
    old_price: "3,999",
  },
  {
    id: 34,
    name: "Lacoste Kids Quartz Watch",
    category: "kid",
    image: p34_img,
    new_price: "2,999",
    old_price: "4,999",
  },
  {
    id: 35,
    name: "Garonne Kids KV20Q468 Kid Scout Watch",
    category: "kid",
    image: p35_img,
    new_price: "2,999",
    old_price: "3,999",
  },
  {
    id: 36,
    name: "Richard Mille RM011  White Asia Exclusive  White Strap Watch",
    category: "kid",
    image: p36_img,
    new_price: "90,999",
    old_price: "1,00,999",
  },
];

export default all_product;
