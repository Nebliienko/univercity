package lb3;

import aima.core.environment.map.ExtendableMap;

public class SimplifiedRoadMapOfUkraine extends ExtendableMap {

    public SimplifiedRoadMapOfUkraine() {
        initMap(this);
    }

    public static final String VINNICA = "Vinnica";
    public static final String DNEPROPETROVSK = "Dnepropetrovsk";
    public static final String DONETSK = "Donetsk";
    public static final String CHERNIGOV = "Chernigov";
    public static final String ZAPOROZHYE = "Zaporozhye";
    public static final String SIMFEROPOL = "Simferopol";
    public static final String KIEV = "Kiev";
    public static final String KIROVOGRAD = "Kirovograd";
    public static final String LUGANSK = "Lugansk";
    public static final String KHARKOV = "Kharkov";
    public static final String KHERSON = "Kherson";
    public static final String NIKOLAEV = "Nikolaev";
    public static final String ODESSA = "Odessa";
    public static final String POLTAVA = "Poltava";
    public static final String SUMY = "Sumy";
    public static final String CHERKASSY = "Cherkassy";

    private static void initMap(ExtendableMap map) {
        map.clear();
        map.addBidirectionalLink(VINNICA, KIEV, 256d);
        map.addBidirectionalLink(VINNICA, KIROVOGRAD, 316d);
        map.addBidirectionalLink(VINNICA, ODESSA, 428d);
        map.addBidirectionalLink(KIEV, CHERNIGOV, 149d);
        map.addBidirectionalLink(KIEV, SUMY, 346d);
        map.addBidirectionalLink(KIEV, CHERKASSY, 190d);
        map.addBidirectionalLink(CHERNIGOV, SUMY, 350d);
        map.addBidirectionalLink(SUMY, KHARKOV, 190d);
        map.addBidirectionalLink(KHARKOV, POLTAVA, 141d);
        map.addBidirectionalLink(KHARKOV, DNEPROPETROVSK, 213d);
        map.addBidirectionalLink(KHARKOV, LUGANSK, 333d);
        map.addBidirectionalLink(LUGANSK, DONETSK, 148d);
        map.addBidirectionalLink(DONETSK, ZAPOROZHYE, 217d);
        map.addBidirectionalLink(ZAPOROZHYE, DNEPROPETROVSK, 81d);
        map.addBidirectionalLink(ZAPOROZHYE, SIMFEROPOL, 365d);
        map.addBidirectionalLink(SIMFEROPOL, KHERSON, 221d);
        map.addBidirectionalLink(KHERSON, NIKOLAEV, 51d);
        map.addBidirectionalLink(NIKOLAEV, ODESSA, 120d);
        map.addBidirectionalLink(NIKOLAEV, KIROVOGRAD, 174d);
        map.addBidirectionalLink(ODESSA, KIROVOGRAD, 294d);
        map.addBidirectionalLink(KIROVOGRAD, DNEPROPETROVSK, 294d);
        map.addBidirectionalLink(KIROVOGRAD, POLTAVA, 246d);
        map.addBidirectionalLink(KIROVOGRAD, CHERKASSY, 126d);
        map.addBidirectionalLink(CHERKASSY, POLTAVA, 279d);
        map.addBidirectionalLink(POLTAVA, DNEPROPETROVSK, 196d);

        map.setDistAndDirToRefLocation(VINNICA, 748, 111);
        map.setDistAndDirToRefLocation(DNEPROPETROVSK, 81, 169);
        map.setDistAndDirToRefLocation(DONETSK, 217, 261);
        map.setDistAndDirToRefLocation(POLTAVA, 270, 165);
        map.setDistAndDirToRefLocation(CHERKASSY, 405, 130);
        map.setDistAndDirToRefLocation(KIROVOGRAD, 303, 112);
        map.setDistAndDirToRefLocation(KHARKOV, 287, 192);
        map.setDistAndDirToRefLocation(KIEV, 607, 133);
        map.setDistAndDirToRefLocation(CHERNIGOV, 747, 147);
        map.setDistAndDirToRefLocation(SUMY, 477, 176);
        map.setDistAndDirToRefLocation(LUGANSK, 365, 252);
        map.setDistAndDirToRefLocation(ZAPOROZHYE, 0, 360);
        map.setDistAndDirToRefLocation(SIMFEROPOL, 365, 20);
        map.setDistAndDirToRefLocation(KHERSON, 297, 58);
        map.setDistAndDirToRefLocation(NIKOLAEV, 377, 70);
        map.setDistAndDirToRefLocation(ODESSA, 497, 67);
    }

}
