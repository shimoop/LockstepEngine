// Copyright 2019 谭杰鹏. All Rights Reserved //https://github.com/JiepengTan 


//#define DONT_USE_GENERATE_CODE                                                              
//------------------------------------------------------------------------------              
// <auto-generated>                                                                           
//     This code was generated by Lockstep.CodeGenerator                                                            
//     Changes to this file may cause incorrect behavior and will be lost if                  
//     the code is regenerated.                                                               
//     https://github.com/JiepengTan/LockstepEngine                                         
// </auto-generated>                                                                          
//------------------------------------------------------------------------------  
using System;
using Lockstep.Math;
namespace Lockstep.Math
{
	public static class LUTAcos
	{
		public static readonly int COUNT;
		public static readonly int HALF_COUNT;
		public static readonly int[] table;
		static LUTAcos()
		{
			COUNT = 4000;
			HALF_COUNT = COUNT >> 1;
			table = new int[]
			{
				3141592,3109967,3096867,3086813,3078336,3070867,3064113,3057902,3052119,3046689,3041550,3036663,3031993,3027513,3023201,3019041,3015017,3011116,3007327,3003642,3000053,2996551,2993132,2989789,2986517,2983313,2980172,2977090,2974064,2971092,2968170,2965296,2962467,2959682,2956939,2954236,2951570,2948941,2946346,2943786,2941257,2938760,2936293,2933855,2931444,2929060,2926703,2924371,2922063,2919778,2917517,2915278,2913060,2910863,2908687,2906531,2904393,2902275,2900175,2898092,2896027,2893978,2891946,2889931,2887930,2885946,2883976,2882020,2880079,2878153,2876239,2874339,2872452,2870579,2868717,2866868,2865031,2863205,2861392,2859589,2857798,2856018,2854248,2852489,2850741,2849002,2847274,2845555,2843846,2842146,2840456,2838774,2837102,2835439,2833784,2832138,2830501,2828871,2827250,2825637,
				2824032,2822434,2820845,2819262,2817688,2816120,2814560,2813007,2811461,2809923,2808390,2806865,2805346,2803834,2802329,2800829,2799336,2797850,2796369,2794895,2793426,2791964,2790507,2789056,2787611,2786171,2784737,2783308,2781885,2780467,2779055,2777648,2776246,2774849,2773457,2772070,2770688,2769311,2767939,2766571,2765209,2763851,2762497,2761148,2759804,2758465,2757129,2755798,2754472,2753149,2751832,2750518,2749208,2747903,2746601,2745304,2744010,2742721,2741436,2740154,2738876,2737602,2736332,2735066,2733803,2732544,2731289,2730037,2728789,2727545,2726304,2725066,2723832,2722601,2721374,2720150,2718930,2717712,2716498,2715287,2714080,2712876,2711674,2710476,2709281,2708090,2706901,2705715,2704532,2703352,2702176,2701002,2699831,2698663,2697498,2696335,2695176,2694019,2692865,2691714,
				2690565,2689420,2688277,2687136,2685999,2684864,2683731,2682601,2681474,2680349,2679227,2678107,2676990,2675875,2674763,2673654,2672546,2671441,2670339,2669239,2668141,2667046,2665952,2664862,2663773,2662687,2661603,2660521,2659442,2658365,2657290,2656217,2655146,2654078,2653012,2651947,2650885,2649825,2648767,2647712,2646658,2645606,2644557,2643509,2642464,2641420,2640378,2639339,2638301,2637265,2636232,2635200,2634170,2633142,2632116,2631092,2630069,2629049,2628030,2627013,2625998,2624985,2623974,2622964,2621956,2620950,2619946,2618943,2617943,2616944,2615946,2614951,2613957,2612964,2611974,2610985,2609998,2609012,2608028,2607046,2606065,2605087,2604109,2603133,2602159,2601186,2600215,2599246,2598278,2597311,2596347,2595383,2594422,2593461,2592503,2591545,2590590,2589635,2588682,2587731,
				2586781,2585833,2584886,2583940,2582996,2582053,2581112,2580172,2579234,2578297,2577361,2576427,2575494,2574562,2573632,2572703,2571776,2570849,2569925,2569001,2568079,2567158,2566239,2565320,2564404,2563488,2562573,2561660,2560749,2559838,2558928,2558021,2557114,2556208,2555304,2554401,2553499,2552598,2551699,2550801,2549903,2549008,2548113,2547219,2546327,2545436,2544546,2543658,2542770,2541883,2540998,2540114,2539231,2538349,2537468,2536588,2535710,2534832,2533956,2533081,2532207,2531334,2530462,2529591,2528721,2527853,2526985,2526118,2525253,2524389,2523525,2522663,2521801,2520941,2520082,2519224,2518367,2517510,2516655,2515801,2514948,2514096,2513245,2512395,2511545,2510697,2509850,2509004,2508159,2507314,2506471,2505629,2504788,2503947,2503108,2502269,2501432,2500595,2499760,2498925,
				2498091,2497258,2496426,2495595,2494765,2493936,2493108,2492280,2491454,2490628,2489804,2488980,2488157,2487335,2486513,2485693,2484874,2484055,2483237,2482421,2481605,2480790,2479975,2479162,2478350,2477538,2476727,2475917,2475108,2474299,2473492,2472685,2471879,2471074,2470270,2469467,2468664,2467862,2467061,2466261,2465462,2464663,2463865,2463068,2462272,2461477,2460682,2459888,2459095,2458302,2457511,2456720,2455930,2455141,2454352,2453564,2452778,2451991,2451206,2450421,2449637,2448854,2448071,2447289,2446508,2445728,2444948,2444169,2443391,2442614,2441837,2441061,2440286,2439511,2438737,2437964,2437192,2436420,2435649,2434879,2434109,2433340,2432572,2431804,2431037,2430271,2429505,2428740,2427976,2427213,2426450,2425688,2424926,2424165,2423405,2422646,2421887,2421129,2420371,2419614,
				2418858,2418102,2417347,2416593,2415839,2415086,2414334,2413582,2412831,2412081,2411331,2410581,2409833,2409085,2408337,2407591,2406845,2406099,2405354,2404610,2403866,2403123,2402381,2401639,2400897,2400157,2399417,2398677,2397938,2397200,2396462,2395725,2394989,2394253,2393518,2392783,2392049,2391315,2390582,2389850,2389118,2388386,2387656,2386926,2386196,2385467,2384738,2384011,2383283,2382556,2381830,2381104,2380379,2379655,2378931,2378207,2377485,2376762,2376040,2375319,2374598,2373878,2373158,2372439,2371721,2371002,2370285,2369568,2368851,2368135,2367420,2366705,2365991,2365277,2364563,2363851,2363138,2362426,2361715,2361004,2360294,2359584,2358875,2358166,2357458,2356750,2356043,2355336,2354630,2353924,2353219,2352514,2351810,2351106,2350403,2349700,2348998,2348296,2347594,2346894,
				2346193,2345494,2344794,2344095,2343397,2342699,2342001,2341304,2340607,2339911,2339216,2338521,2337826,2337132,2336438,2335745,2335052,2334359,2333667,2332976,2332285,2331594,2330904,2330214,2329525,2328837,2328148,2327461,2326773,2326086,2325400,2324713,2324028,2323343,2322658,2321974,2321290,2320606,2319923,2319241,2318558,2317877,2317195,2316515,2315834,2315154,2314475,2313796,2313117,2312438,2311761,2311083,2310406,2309729,2309053,2308377,2307702,2307027,2306353,2305678,2305005,2304331,2303658,2302986,2302314,2301642,2300971,2300300,2299629,2298959,2298290,2297620,2296952,2296283,2295615,2294947,2294280,2293613,2292947,2292280,2291615,2290949,2290284,2289620,2288955,2288292,2287628,2286965,2286303,2285640,2284978,2284317,2283656,2282995,2282335,2281675,2281015,2280356,2279697,2279038,
				2278380,2277723,2277065,2276408,2275751,2275095,2274439,2273784,2273128,2272474,2271819,2271165,2270511,2269858,2269205,2268552,2267900,2267248,2266596,2265945,2265294,2264644,2263993,2263344,2262694,2262045,2261396,2260748,2260099,2259452,2258804,2258157,2257511,2256864,2256218,2255573,2254927,2254282,2253637,2252993,2252349,2251705,2251062,2250419,2249776,2249134,2248492,2247850,2247209,2246568,2245927,2245287,2244647,2244007,2243368,2242729,2242090,2241452,2240814,2240176,2239539,2238901,2238265,2237628,2236992,2236356,2235721,2235085,2234451,2233816,2233182,2232548,2231914,2231281,2230648,2230015,2229383,2228751,2228119,2227488,2226856,2226226,2225595,2224965,2224335,2223705,2223076,2222447,2221818,2221190,2220562,2219934,2219306,2218679,2218052,2217426,2216799,2216173,2215548,2214922,
				2214297,2213672,2213047,2212423,2211799,2211176,2210552,2209929,2209306,2208684,2208061,2207440,2206818,2206197,2205575,2204955,2204334,2203714,2203094,2202474,2201855,2201236,2200617,2199998,2199380,2198762,2198144,2197527,2196909,2196293,2195676,2195060,2194443,2193828,2193212,2192597,2191982,2191367,2190752,2190139,2189524,2188911,2188297,2187684,2187072,2186459,2185847,2185235,2184623,2184011,2183400,2182789,2182178,2181568,2180958,2180348,2179738,2179128,2178519,2177910,2177302,2176693,2176085,2175477,2174870,2174262,2173655,2173048,2172441,2171835,2171229,2170623,2170018,2169412,2168807,2168202,2167598,2166993,2166389,2165785,2165182,2164578,2163975,2163372,2162770,2162167,2161565,2160963,2160362,2159760,2159159,2158558,2157957,2157357,2156756,2156157,2155557,2154957,2154358,2153759,
				2153160,2152561,2151963,2151365,2150767,2150170,2149572,2148975,2148378,2147781,2147185,2146589,2145993,2145397,2144801,2144206,2143611,2143016,2142421,2141827,2141233,2140639,2140045,2139452,2138859,2138266,2137673,2137080,2136488,2135895,2135304,2134712,2134120,2133529,2132938,2132347,2131757,2131166,2130576,2129986,2129396,2128807,2128218,2127629,2127040,2126451,2125863,2125274,2124686,2124099,2123511,2122924,2122336,2121750,2121163,2120576,2119990,2119404,2118818,2118232,2117647,2117062,2116477,2115892,2115307,2114722,2114138,2113554,2112971,2112387,2111804,2111220,2110637,2110054,2109472,2108890,2108307,2107725,2107144,2106562,2105981,2105400,2104819,2104238,2103657,2103077,2102497,2101917,2101337,2100757,2100178,2099599,2099020,2098441,2097862,2097284,2096705,2096127,2095550,2094972,
				2094395,2093817,2093240,2092664,2092087,2091510,2090934,2090358,2089782,2089206,2088631,2088055,2087480,2086905,2086330,2085756,2085181,2084607,2084033,2083459,2082885,2082312,2081739,2081166,2080593,2080020,2079447,2078875,2078303,2077731,2077159,2076587,2076016,2075445,2074873,2074302,2073732,2073161,2072591,2072021,2071450,2070881,2070311,2069741,2069172,2068603,2068034,2067465,2066897,2066328,2065760,2065192,2064624,2064056,2063488,2062921,2062354,2061787,2061220,2060653,2060087,2059520,2058954,2058388,2057822,2057256,2056691,2056126,2055560,2054995,2054430,2053866,2053301,2052737,2052173,2051609,2051045,2050481,2049918,2049354,2048791,2048228,2047665,2047102,2046540,2045978,2045415,2044853,2044291,2043730,2043168,2042607,2042045,2041484,2040923,2040363,2039802,2039242,2038681,2038121,
				2037561,2037001,2036442,2035882,2035323,2034764,2034205,2033646,2033087,2032528,2031970,2031412,2030854,2030296,2029738,2029180,2028623,2028066,2027508,2026951,2026395,2025838,2025281,2024725,2024168,2023612,2023056,2022501,2021945,2021389,2020834,2020279,2019724,2019169,2018614,2018059,2017505,2016951,2016396,2015842,2015289,2014735,2014181,2013628,2013075,2012521,2011968,2011415,2010863,2010310,2009758,2009205,2008653,2008101,2007550,2006998,2006446,2005895,2005343,2004792,2004241,2003690,2003139,2002589,2002038,2001488,2000938,2000388,1999838,1999288,1998739,1998189,1997640,1997091,1996541,1995993,1995444,1994895,1994347,1993798,1993250,1992702,1992154,1991606,1991058,1990511,1989963,1989416,1988869,1988322,1987775,1987228,1986681,1986135,1985588,1985042,1984496,1983950,1983404,1982858,
				1982313,1981767,1981222,1980677,1980131,1979587,1979042,1978497,1977952,1977408,1976864,1976320,1975775,1975232,1974688,1974144,1973600,1973057,1972514,1971971,1971427,1970884,1970342,1969799,1969256,1968714,1968172,1967630,1967087,1966545,1966004,1965462,1964920,1964379,1963838,1963296,1962755,1962214,1961673,1961133,1960592,1960052,1959511,1958971,1958431,1957891,1957351,1956811,1956272,1955732,1955193,1954653,1954114,1953575,1953036,1952497,1951959,1951420,1950881,1950343,1949805,1949267,1948729,1948191,1947653,1947115,1946578,1946040,1945503,1944966,1944429,1943892,1943355,1942818,1942281,1941745,1941208,1940672,1940136,1939600,1939064,1938528,1937992,1937456,1936921,1936385,1935850,1935315,1934780,1934245,1933710,1933175,1932640,1932106,1931571,1931037,1930503,1929969,1929435,1928901,
				1928367,1927833,1927300,1926766,1926233,1925699,1925166,1924633,1924100,1923567,1923035,1922502,1921969,1921437,1920905,1920372,1919840,1919308,1918776,1918244,1917713,1917181,1916650,1916118,1915587,1915056,1914525,1913993,1913463,1912932,1912401,1911870,1911340,1910809,1910279,1909749,1909219,1908689,1908159,1907629,1907099,1906570,1906040,1905511,1904981,1904452,1903923,1903394,1902865,1902336,1901808,1901279,1900750,1900222,1899694,1899165,1898637,1898109,1897581,1897053,1896525,1895998,1895470,1894942,1894415,1893888,1893360,1892833,1892306,1891779,1891252,1890726,1890199,1889672,1889146,1888620,1888093,1887567,1887041,1886515,1885989,1885463,1884937,1884412,1883886,1883360,1882835,1882310,1881784,1881259,1880734,1880209,1879684,1879160,1878635,1878110,1877586,1877061,1876537,1876013,
				1875488,1874964,1874440,1873916,1873393,1872869,1872345,1871822,1871298,1870775,1870251,1869728,1869205,1868682,1868159,1867636,1867113,1866590,1866068,1865545,1865023,1864500,1863978,1863456,1862933,1862411,1861889,1861368,1860846,1860324,1859802,1859281,1858759,1858238,1857716,1857195,1856674,1856153,1855632,1855111,1854590,1854069,1853548,1853028,1852507,1851987,1851466,1850946,1850426,1849906,1849385,1848865,1848346,1847826,1847306,1846786,1846267,1845747,1845228,1844708,1844189,1843670,1843150,1842631,1842112,1841593,1841074,1840556,1840037,1839518,1839000,1838481,1837963,1837445,1836926,1836408,1835890,1835372,1834854,1834336,1833818,1833300,1832783,1832265,1831747,1831230,1830712,1830195,1829678,1829161,1828644,1828127,1827610,1827093,1826576,1826059,1825542,1825026,1824509,1823992,
				1823476,1822960,1822443,1821927,1821411,1820895,1820379,1819863,1819347,1818831,1818315,1817800,1817284,1816769,1816253,1815738,1815222,1814707,1814192,1813677,1813162,1812647,1812132,1811617,1811102,1810587,1810073,1809558,1809043,1808529,1808014,1807500,1806986,1806471,1805957,1805443,1804929,1804415,1803901,1803387,1802873,1802360,1801846,1801332,1800819,1800305,1799792,1799279,1798765,1798252,1797739,1797226,1796713,1796200,1795687,1795174,1794661,1794148,1793636,1793123,1792610,1792098,1791585,1791073,1790561,1790048,1789536,1789024,1788512,1788000,1787488,1786976,1786464,1785952,1785440,1784929,1784417,1783905,1783394,1782882,1782371,1781859,1781348,1780837,1780326,1779814,1779303,1778792,1778281,1777770,1777260,1776749,1776238,1775727,1775217,1774706,1774195,1773685,1773175,1772664,
				1772154,1771643,1771133,1770623,1770113,1769603,1769093,1768583,1768073,1767563,1767053,1766543,1766034,1765524,1765015,1764505,1763996,1763486,1762977,1762467,1761958,1761449,1760939,1760430,1759921,1759412,1758903,1758394,1757885,1757377,1756868,1756359,1755850,1755342,1754833,1754324,1753816,1753307,1752799,1752291,1751782,1751274,1750766,1750258,1749749,1749241,1748733,1748225,1747717,1747209,1746702,1746194,1745686,1745178,1744671,1744163,1743655,1743148,1742640,1742133,1741626,1741118,1740611,1740104,1739596,1739089,1738582,1738075,1737568,1737061,1736554,1736047,1735540,1735033,1734526,1734020,1733513,1733006,1732500,1731993,1731486,1730980,1730473,1729967,1729461,1728954,1728448,1727942,1727436,1726929,1726423,1725917,1725411,1724905,1724399,1723893,1723387,1722881,1722376,1721870,
				1721364,1720858,1720353,1719847,1719341,1718836,1718330,1717825,1717320,1716814,1716309,1715803,1715298,1714793,1714288,1713783,1713277,1712772,1712267,1711762,1711257,1710752,1710247,1709743,1709238,1708733,1708228,1707723,1707219,1706714,1706209,1705705,1705200,1704696,1704191,1703687,1703182,1702678,1702173,1701669,1701165,1700661,1700156,1699652,1699148,1698644,1698140,1697636,1697132,1696628,1696124,1695620,1695116,1694612,1694108,1693604,1693101,1692597,1692093,1691589,1691086,1690582,1690078,1689575,1689071,1688568,1688064,1687561,1687058,1686554,1686051,1685547,1685044,1684541,1684038,1683534,1683031,1682528,1682025,1681522,1681019,1680516,1680013,1679510,1679007,1678504,1678001,1677498,1676995,1676493,1675990,1675487,1674984,1674481,1673979,1673476,1672973,1672471,1671968,1671466,
				1670963,1670461,1669958,1669456,1668953,1668451,1667949,1667446,1666944,1666442,1665939,1665437,1664935,1664433,1663930,1663428,1662926,1662424,1661922,1661420,1660918,1660416,1659914,1659412,1658910,1658408,1657906,1657404,1656902,1656400,1655899,1655397,1654895,1654393,1653891,1653390,1652888,1652386,1651885,1651383,1650881,1650380,1649878,1649377,1648875,1648374,1647872,1647371,1646869,1646368,1645866,1645365,1644864,1644362,1643861,1643360,1642858,1642357,1641856,1641354,1640853,1640352,1639851,1639350,1638848,1638347,1637846,1637345,1636844,1636343,1635842,1635341,1634840,1634339,1633838,1633337,1632836,1632335,1631834,1631333,1630832,1630331,1629830,1629329,1628828,1628328,1627827,1627326,1626825,1626324,1625824,1625323,1624822,1624321,1623821,1623320,1622819,1622319,1621818,1621317,
				1620817,1620316,1619815,1619315,1618814,1618314,1617813,1617313,1616812,1616312,1615811,1615311,1614810,1614310,1613809,1613309,1612808,1612308,1611807,1611307,1610806,1610306,1609806,1609305,1608805,1608305,1607804,1607304,1606804,1606303,1605803,1605303,1604802,1604302,1603802,1603302,1602801,1602301,1601801,1601301,1600800,1600300,1599800,1599300,1598799,1598299,1597799,1597299,1596799,1596299,1595798,1595298,1594798,1594298,1593798,1593298,1592798,1592298,1591797,1591297,1590797,1590297,1589797,1589297,1588797,1588297,1587797,1587297,1586796,1586296,1585796,1585296,1584796,1584296,1583796,1583296,1582796,1582296,1581796,1581296,1580796,1580296,1579796,1579296,1578796,1578296,1577796,1577296,1576796,1576296,1575796,1575296,1574796,1574296,1573796,1573296,1572796,1572296,1571796,1571296,
				1570796,1570296,1569796,1569296,1568796,1568296,1567796,1567296,1566796,1566296,1565796,1565296,1564796,1564296,1563796,1563296,1562796,1562296,1561796,1561296,1560796,1560296,1559796,1559296,1558796,1558295,1557796,1557295,1556795,1556295,1555795,1555295,1554795,1554295,1553795,1553295,1552795,1552295,1551795,1551295,1550794,1550294,1549794,1549294,1548794,1548294,1547794,1547294,1546794,1546293,1545793,1545293,1544793,1544293,1543793,1543292,1542792,1542292,1541792,1541292,1540791,1540291,1539791,1539291,1538790,1538290,1537790,1537290,1536789,1536289,1535789,1535288,1534788,1534288,1533787,1533287,1532787,1532286,1531786,1531286,1530785,1530285,1529784,1529284,1528783,1528283,1527783,1527282,1526782,1526281,1525781,1525280,1524780,1524279,1523779,1523278,1522777,1522277,1521776,1521276,
				1520775,1520274,1519774,1519273,1518772,1518272,1517771,1517270,1516770,1516269,1515768,1515267,1514767,1514266,1513765,1513264,1512763,1512262,1511762,1511261,1510760,1510259,1509758,1509257,1508756,1508255,1507754,1507253,1506752,1506251,1505750,1505249,1504748,1504247,1503746,1503244,1502743,1502242,1501741,1501240,1500738,1500237,1499736,1499235,1498733,1498232,1497731,1497229,1496728,1496227,1495725,1495224,1494722,1494221,1493720,1493218,1492717,1492215,1491713,1491212,1490710,1490209,1489707,1489205,1488704,1488202,1487700,1487198,1486697,1486195,1485693,1485191,1484689,1484188,1483686,1483184,1482682,1482180,1481678,1481176,1480674,1480172,1479670,1479168,1478666,1478163,1477661,1477159,1476657,1476155,1475652,1475150,1474648,1474145,1473643,1473141,1472638,1472136,1471633,1471131,
				1470628,1470126,1469623,1469121,1468618,1468116,1467613,1467110,1466607,1466105,1465602,1465099,1464596,1464093,1463591,1463088,1462585,1462082,1461579,1461076,1460573,1460070,1459567,1459064,1458560,1458057,1457554,1457051,1456547,1456044,1455541,1455037,1454534,1454031,1453527,1453024,1452520,1452017,1451513,1451010,1450506,1450002,1449499,1448995,1448491,1447987,1447484,1446980,1446476,1445972,1445468,1444964,1444460,1443956,1443452,1442948,1442444,1441940,1441435,1440931,1440427,1439923,1439418,1438914,1438409,1437905,1437401,1436896,1436392,1435887,1435382,1434878,1434373,1433868,1433364,1432859,1432354,1431849,1431344,1430839,1430334,1429829,1429324,1428819,1428314,1427809,1427304,1426799,1426293,1425788,1425283,1424777,1424272,1423767,1423261,1422756,1422250,1421745,1421239,1420733,
				1420228,1419722,1419216,1418710,1418204,1417698,1417193,1416687,1416180,1415674,1415168,1414662,1414156,1413650,1413144,1412637,1412131,1411625,1411118,1410612,1410105,1409599,1409092,1408585,1408079,1407572,1407065,1406558,1406052,1405545,1405038,1404531,1404024,1403517,1403010,1402503,1401995,1401488,1400981,1400474,1399966,1399459,1398951,1398444,1397936,1397429,1396921,1396413,1395906,1395398,1394890,1394382,1393874,1393366,1392858,1392350,1391842,1391334,1390826,1390318,1389809,1389301,1388793,1388284,1387776,1387267,1386759,1386250,1385741,1385233,1384724,1384215,1383706,1383197,1382688,1382179,1381670,1381161,1380652,1380143,1379634,1379124,1378615,1378106,1377596,1377087,1376577,1376067,1375558,1375048,1374538,1374029,1373519,1373009,1372499,1371989,1371479,1370969,1370458,1369948,
				1369438,1368928,1368417,1367907,1367396,1366886,1366375,1365864,1365354,1364843,1364332,1363821,1363310,1362799,1362288,1361777,1361266,1360755,1360244,1359732,1359221,1358709,1358198,1357686,1357175,1356663,1356151,1355640,1355128,1354616,1354104,1353592,1353080,1352568,1352056,1351543,1351031,1350519,1350006,1349494,1348981,1348469,1347956,1347443,1346931,1346418,1345905,1345392,1344879,1344366,1343853,1343340,1342826,1342313,1341800,1341286,1340773,1340259,1339746,1339232,1338718,1338204,1337690,1337177,1336663,1336148,1335634,1335120,1334606,1334092,1333577,1333063,1332548,1332034,1331519,1331004,1330490,1329975,1329460,1328945,1328430,1327915,1327400,1326884,1326369,1325854,1325338,1324823,1324307,1323792,1323276,1322760,1322245,1321729,1321213,1320697,1320181,1319664,1319148,1318632,
				1318116,1317599,1317083,1316566,1316049,1315533,1315016,1314499,1313982,1313465,1312948,1312431,1311914,1311396,1310879,1310362,1309844,1309327,1308809,1308291,1307774,1307256,1306738,1306220,1305702,1305184,1304665,1304147,1303629,1303110,1302592,1302073,1301555,1301036,1300517,1299998,1299479,1298960,1298441,1297922,1297403,1296883,1296364,1295845,1295325,1294805,1294286,1293766,1293246,1292726,1292206,1291686,1291166,1290646,1290125,1289605,1289084,1288564,1288043,1287523,1287002,1286481,1285960,1285439,1284918,1284397,1283875,1283354,1282832,1282311,1281789,1281268,1280746,1280224,1279702,1279180,1278658,1278136,1277614,1277091,1276569,1276046,1275524,1275001,1274479,1273956,1273433,1272910,1272387,1271864,1271340,1270817,1270294,1269770,1269246,1268723,1268199,1267675,1267151,1266627,
				1266103,1265579,1265055,1264530,1264006,1263481,1262957,1262432,1261907,1261382,1260857,1260332,1259807,1259282,1258757,1258231,1257706,1257180,1256654,1256129,1255603,1255077,1254551,1254025,1253498,1252972,1252446,1251919,1251393,1250866,1250339,1249812,1249285,1248758,1248231,1247704,1247177,1246649,1246122,1245594,1245066,1244539,1244011,1243483,1242955,1242426,1241898,1241370,1240841,1240313,1239784,1239255,1238726,1238198,1237668,1237139,1236610,1236081,1235551,1235022,1234492,1233963,1233433,1232903,1232373,1231843,1231312,1230782,1230252,1229721,1229191,1228660,1228129,1227598,1227067,1226536,1226005,1225473,1224942,1224411,1223879,1223347,1222815,1222283,1221751,1221219,1220687,1220155,1219622,1219090,1218557,1218024,1217491,1216958,1216425,1215892,1215359,1214825,1214292,1213758,
				1213225,1212691,1212157,1211623,1211089,1210555,1210020,1209486,1208951,1208417,1207882,1207347,1206812,1206277,1205742,1205206,1204671,1204135,1203600,1203064,1202528,1201992,1201456,1200920,1200383,1199847,1199310,1198774,1198237,1197700,1197163,1196626,1196089,1195551,1195014,1194476,1193939,1193401,1192863,1192325,1191787,1191249,1190710,1190172,1189633,1189094,1188556,1188017,1187478,1186938,1186399,1185860,1185320,1184780,1184241,1183701,1183161,1182621,1182080,1181540,1180999,1180459,1179918,1179377,1178836,1178295,1177754,1177213,1176671,1176130,1175588,1175046,1174504,1173962,1173420,1172878,1172335,1171793,1171250,1170707,1170164,1169621,1169078,1168535,1167991,1167448,1166904,1166360,1165816,1165272,1164728,1164184,1163639,1163095,1162550,1162005,1161460,1160915,1160370,1159824,
				1159279,1158733,1158188,1157642,1157096,1156550,1156003,1155457,1154910,1154364,1153817,1153270,1152723,1152176,1151628,1151081,1150533,1149986,1149438,1148890,1148342,1147794,1147245,1146697,1146148,1145599,1145050,1144501,1143952,1143403,1142853,1142303,1141754,1141204,1140654,1140104,1139553,1139003,1138452,1137901,1137351,1136799,1136248,1135697,1135146,1134594,1134042,1133490,1132938,1132386,1131834,1131281,1130729,1130176,1129623,1129070,1128517,1127964,1127410,1126857,1126303,1125749,1125195,1124641,1124087,1123532,1122977,1122423,1121868,1121313,1120758,1120202,1119647,1119091,1118535,1117979,1117423,1116867,1116310,1115754,1115197,1114640,1114083,1113526,1112969,1112411,1111854,1111296,1110738,1110180,1109622,1109063,1108505,1107946,1107387,1106828,1106269,1105709,1105150,1104590,
				1104030,1103471,1102910,1102350,1101790,1101229,1100668,1100107,1099546,1098985,1098424,1097862,1097300,1096738,1096176,1095614,1095052,1094489,1093927,1093364,1092801,1092237,1091674,1091111,1090547,1089983,1089419,1088855,1088290,1087726,1087161,1086596,1086031,1085466,1084901,1084335,1083770,1083204,1082638,1082071,1081505,1080939,1080372,1079805,1079238,1078671,1078103,1077536,1076968,1076400,1075832,1075263,1074695,1074126,1073558,1072989,1072420,1071850,1071281,1070711,1070141,1069571,1069001,1068431,1067860,1067289,1066718,1066147,1065576,1065004,1064433,1063861,1063289,1062717,1062144,1061572,1060999,1060426,1059853,1059280,1058706,1058132,1057559,1056985,1056410,1055836,1055261,1054687,1054112,1053536,1052961,1052385,1051810,1051234,1050658,1050081,1049505,1048928,1048351,1047774,
				1047197,1046620,1046042,1045464,1044886,1044308,1043729,1043151,1042572,1041993,1041414,1040834,1040255,1039675,1039095,1038515,1037935,1037354,1036773,1036192,1035611,1035030,1034448,1033866,1033284,1032702,1032120,1031537,1030954,1030371,1029788,1029205,1028621,1028037,1027453,1026869,1026285,1025700,1025115,1024530,1023945,1023359,1022774,1022188,1021602,1021016,1020429,1019842,1019255,1018668,1018081,1017493,1016905,1016317,1015729,1015141,1014552,1013963,1013374,1012785,1012195,1011605,1011016,1010425,1009835,1009244,1008654,1008063,1007471,1006880,1006288,1005696,1005104,1004512,1003919,1003326,1002733,1002140,1001546,1000953,1000359,999765,999170,998576,997981,997386,996790,996195,995599,995003,994407,993810,993214,992617,992019,991422,990824,990227,989628,989030,
				988432,987833,987234,986634,986035,985435,984835,984235,983635,983034,982433,981832,981230,980629,980027,979424,978822,978219,977617,977013,976410,975806,975203,974598,973994,973389,972784,972179,971574,970968,970363,969756,969150,968543,967937,967329,966722,966114,965507,964898,964290,963681,963072,962463,961854,961244,960634,960024,959413,958803,958192,957580,956969,956357,955745,955133,954520,953907,953294,952681,952067,951453,950839,950225,949610,948995,948380,947764,947148,946532,945916,945299,944682,944065,943448,942830,942212,941594,940975,940356,939737,939118,938498,937878,937258,936637,936016,935395,934774,934152,933530,932908,932285,931663,931039,930416,929792,929168,928544,927920,
				927295,926670,926044,925418,924792,924166,923539,922913,922285,921658,921030,920402,919773,919145,918516,917886,917257,916627,915997,915366,914735,914104,913473,912841,912209,911576,910944,910311,909677,909044,908410,907776,907141,906506,905871,905235,904600,903963,903327,902690,902053,901416,900778,900140,899502,898863,898224,897584,896945,896305,895664,895024,894383,893741,893100,892458,891815,891173,890530,889886,889243,888599,887954,887310,886665,886019,885374,884728,884081,883434,882787,882140,881492,880844,880196,879547,878898,878248,877598,876948,876298,875647,874995,874344,873692,873040,872387,871734,871080,870427,869773,869118,868463,867808,867152,866497,865840,865184,864527,863869,
				863211,862553,861895,861236,860577,859917,859257,858597,857936,857275,856613,855951,855289,854626,853963,853300,852636,851972,851307,850642,849977,849311,848645,847979,847312,846644,845977,845309,844640,843971,843302,842632,841962,841292,840621,839950,839278,838606,837933,837260,836587,835913,835239,834565,833890,833214,832539,831862,831186,830509,829831,829153,828475,827796,827117,826437,825758,825077,824396,823715,823033,822351,821668,820985,820302,819618,818934,818249,817564,816878,816192,815506,814819,814131,813443,812755,812066,811377,810687,809997,809307,808616,807924,807232,806540,805847,805154,804460,803766,803071,802376,801680,800984,800288,799591,798893,798195,797497,796798,796098,
				795398,794698,793997,793296,792594,791892,791189,790486,789782,789077,788373,787667,786962,786255,785549,784841,784134,783425,782717,782007,781298,780587,779877,779165,778453,777741,777028,776315,775601,774887,774172,773456,772740,772024,771307,770589,769871,769153,768433,767714,766993,766273,765551,764830,764107,763384,762661,761937,761212,760487,759761,759035,758308,757581,756853,756125,755396,754666,753936,753205,752474,751742,751010,750276,749543,748809,748074,747339,746603,745866,745129,744391,743653,742914,742175,741435,740694,739953,739211,738469,737725,736982,736238,735493,734747,734001,733254,732507,731759,731010,730261,729511,728761,728009,727258,726505,725752,724999,724244,723489,
				722734,721977,721221,720463,719705,718946,718186,717426,716665,715904,715142,714379,713615,712851,712086,711321,710554,709788,709020,708252,707483,706713,705943,705172,704400,703627,702854,702080,701306,700530,699755,698978,698200,697422,696643,695864,695083,694302,693521,692738,691955,691171,690386,689600,688814,688027,687239,686451,685662,684872,684081,683289,682497,681704,680910,680115,679320,678523,677726,676929,676130,675331,674530,673729,672928,672125,671322,670517,669712,668906,668100,667292,666484,665675,664865,664054,663242,662430,661616,660802,659987,659171,658354,657536,656718,655898,655078,654257,653435,652612,651788,650964,650138,649311,648484,647656,646827,645996,645165,644334,
				643501,642667,641832,640996,640160,639322,638484,637644,636804,635963,635120,634277,633433,632588,631742,630894,630046,629197,628347,627496,626644,625791,624936,624081,623225,622368,621510,620651,619790,618929,618067,617203,616339,615473,614607,613739,612870,612001,611130,610258,609385,608511,607636,606759,605882,605003,604124,603243,602361,601478,600594,599708,598822,597934,597045,596156,595264,594372,593479,592584,591688,590791,589893,588993,588093,587191,586288,585383,584478,583571,582663,581754,580843,579931,579018,578104,577188,576271,575353,574433,573513,572590,571667,570742,569816,568889,567960,567029,566098,565165,564231,563295,562358,561419,560480,559538,558596,557651,556706,555759,
				554811,553861,552909,551957,551002,550046,549089,548130,547170,546208,545245,544280,543314,542346,541376,540405,539433,538458,537483,536505,535526,534546,533563,532579,531594,530607,529618,528627,527635,526641,525645,524648,523649,522648,521646,520641,519636,518628,517618,516607,515594,514578,513562,512543,511523,510500,509476,508450,507422,506392,505360,504326,503291,502253,501213,500172,499128,498083,497035,495985,494934,493880,492824,491766,490706,489644,488580,487514,486445,485375,484302,483227,482150,481070,479988,478905,477818,476730,475639,474546,473451,472353,471253,470150,469045,467938,466828,465716,464601,463484,462365,461242,460118,458990,457861,456728,455593,454455,453315,452172,
				451026,449878,448727,447573,446416,445257,444094,442929,441761,440590,439416,438239,437059,435877,434691,433502,432310,431115,429917,428716,427512,426304,425093,423879,422662,421441,420218,418990,417760,416525,415288,414047,412802,411554,410303,409047,407788,406526,405259,403989,402715,401438,400156,398871,397581,396288,394991,393689,392384,391074,389760,388442,387120,385793,384462,383127,381787,380443,379094,377741,376383,375020,373653,372281,370904,369522,368135,366743,365346,363944,362537,361124,359707,358283,356855,355421,353981,352536,351085,349628,348166,346697,345223,343742,342255,340762,339263,337757,336245,334726,333201,331669,330130,328584,327031,325471,323904,322329,320747,319157,
				317560,315955,314342,312720,311091,309454,307807,306153,304489,302817,301136,299446,297746,296037,294318,292590,290851,289102,287343,285574,283794,282002,280200,278386,276561,274724,272875,271013,269139,267252,265353,263439,261512,259571,257616,255646,253661,251661,249645,247613,245565,243500,241417,239317,237198,235061,232905,230728,228532,226314,224075,221813,219529,217221,214889,212531,210148,207737,205299,202832,200334,197806,195245,192651,190022,187356,184653,181909,179124,176296,173422,170500,167527,164502,161420,158278,155074,151803,148460,145040,141539,137950,134264,130476,126575,122551,118390,114079,109599,104929,100041,94903,89472,83690,77479,70725,63255,54779,44724,31624,
				0,
			};
		}
	}
}