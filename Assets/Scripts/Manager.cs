using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour

{


    public GameObject s0,S0R,S0D, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30, s31, s32, s33, s34, s35, s36;

    void Update()
    {
        s0 = GameObject.FindGameObjectWithTag("0");
        S0R = GameObject.FindGameObjectWithTag("0R");
        S0D = GameObject.FindGameObjectWithTag("0D");
        s1 = GameObject.FindGameObjectWithTag("1");
        s2 = GameObject.FindGameObjectWithTag("2");
        s3 = GameObject.FindGameObjectWithTag("3");
        s4 = GameObject.FindGameObjectWithTag("4");
        s5 = GameObject.FindGameObjectWithTag("5");
        s6 = GameObject.FindGameObjectWithTag("6");
        s7 = GameObject.FindGameObjectWithTag("7");
        s8 = GameObject.FindGameObjectWithTag("8");
        s9 = GameObject.FindGameObjectWithTag("9");
        s10 = GameObject.FindGameObjectWithTag("10");
        s11 = GameObject.FindGameObjectWithTag("11");
        s12 = GameObject.FindGameObjectWithTag("12");
        s13 = GameObject.FindGameObjectWithTag("13");
        s14 = GameObject.FindGameObjectWithTag("14");
        s15 = GameObject.FindGameObjectWithTag("15");
        s16 = GameObject.FindGameObjectWithTag("16");
        s17 = GameObject.FindGameObjectWithTag("17");
        s18 = GameObject.FindGameObjectWithTag("18");
        s19 = GameObject.FindGameObjectWithTag("19");
        s20 = GameObject.FindGameObjectWithTag("20");
        s21 = GameObject.FindGameObjectWithTag("21");
        s22 = GameObject.FindGameObjectWithTag("22");
        s23 = GameObject.FindGameObjectWithTag("23");
        s24 = GameObject.FindGameObjectWithTag("24");
        s25 = GameObject.FindGameObjectWithTag("25");
        s26 = GameObject.FindGameObjectWithTag("26");
        s27 = GameObject.FindGameObjectWithTag("27");
        s28 = GameObject.FindGameObjectWithTag("28");
        s29 = GameObject.FindGameObjectWithTag("29");
        s30 = GameObject.FindGameObjectWithTag("30");
        s31 = GameObject.FindGameObjectWithTag("31");
        s32 = GameObject.FindGameObjectWithTag("32");

        s34 = GameObject.FindGameObjectWithTag("34");
        s35 = GameObject.FindGameObjectWithTag("35");
        s36 = GameObject.FindGameObjectWithTag("36");



    }


    // Start is called before the first frame update
    void Start()
    {


    }
    public void GetData()
    {
        StartCoroutine(RequestJasonData());
    }
    IEnumerator RequestJasonData()
    {
        string CovidcasesURL = "https://api.covid19india.org/data.json";
        print(CovidcasesURL);
        using (UnityWebRequest webData = UnityWebRequest.Get(CovidcasesURL))
        {
            yield return webData.SendWebRequest();
            if (webData.isNetworkError || webData.isHttpError)
            {
                Debug.Log("-----------ERROR--------");
            }
            else
            {
                if (webData.isDone)
                {
                    JSONNode jsonData = JSON.Parse(System.Text.Encoding.UTF8.GetString(webData.downloadHandler.data));
                    if (jsonData == null)
                    {
                        Debug.Log("-----------ERROR--------");
                    }
                    else
                    {
                        Debug.Log("-----------JSON DATA--------");
                        print("jsonData.count:" + jsonData.Count);
                        if (s0 != null)
                        {
                            s0.gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().text = jsonData["statewise"][0]["active"];
                            s0.gameObject.transform.GetChild(1).GetComponent<TextMeshPro>().text = jsonData["statewise"][0]["lastupdatedtime"];
                            
                        }
                        if (S0D != null)
                        {
                            S0D.gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().text = jsonData["statewise"][0]["deaths"];
                            
                        }
                        if (S0R != null)
                        {
                            S0R.gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().text = jsonData["statewise"][0]["recovered"];
                            
                        }
                        if (s1 != null)
                        {
                            s1.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][1]["state"];
                            s1.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][1]["active"];
                            s1.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][1]["deaths"];
                            s1.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][1]["recovered"];
                        }
                        if (s2 != null)
                        {
                            s2.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][2]["state"];
                            s2.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][2]["active"];
                            s2.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][2]["deaths"];
                            s2.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][2]["recovered"];

                        }
                        if (s3 != null)
                        {
                            s3.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][3]["state"];
                            s3.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][3]["active"];
                            s3.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][3]["deaths"];
                            s3.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][3]["recovered"];

                        }
                        if (s4 != null)
                        {
                            s4.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][4]["state"];
                            s4.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][4]["active"];
                            s4.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][4]["deaths"];
                            s4.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][4]["recovered"];

                        }
                        if (s5 != null)
                        {
                            s5.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][5]["state"];
                            s5.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][5]["active"];
                            s5.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][5]["deaths"];
                            s5.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][5]["recovered"];

                        }
                        if (s6 != null)
                        {
                            s6.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][6]["state"];
                            s6.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][6]["active"];
                            s6.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][6]["deaths"];
                            s6.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][6]["recovered"];

                        }
                        if (s7 != null)
                        {
                            s7.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][7]["state"];
                            s7.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][7]["active"];
                            s7.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][7]["deaths"];
                            s7.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][7]["recovered"];
                        }
                        if (s8 != null)
                        {
                            s8.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][8]["state"];
                            s8.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][8]["active"];
                            s8.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][8]["deaths"];
                            s8.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][8]["recovered"];
                        }
                        if (s9 != null)
                        {
                            s9.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][9]["state"];
                            s9.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][9]["active"];
                            s9.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][9]["deaths"];
                            s9.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][9]["recovered"];
                        }
                        if (s10 != null)
                        {
                            s10.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][10]["state"];
                            s10.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][10]["active"];
                            s10.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][10]["deaths"];
                            s10.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][10]["recovered"];
                        }
                        if (s11 != null)
                        {
                            s11.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][11]["state"];
                            s11.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][11]["active"];
                            s11.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][11]["deaths"];
                            s11.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][11]["recovered"];
                        }
                        if (s12 != null)
                        {
                            s12.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][12]["state"];
                            s12.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][12]["active"];
                            s12.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][12]["deaths"];
                            s12.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][12]["recovered"];
                        }
                        if (s13 != null)
                        {
                            s13.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][13]["state"];
                            s13.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][13]["active"];
                            s13.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][13]["deaths"];
                            s13.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][13]["recovered"];
                        }
                        if (s14 != null)
                        {
                            s14.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][14]["state"];
                            s14.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][14]["active"];
                            s14.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][14]["deaths"];
                            s14.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][14]["recovered"];
                        }
                        if (s15 != null)
                        {
                            s15.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][15]["state"];
                            s15.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][15]["active"];
                            s15.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][15]["deaths"];
                            s15.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][15]["recovered"];
                        }
                        if (s16 != null)
                        {
                            s16.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][16]["state"];
                            s16.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][16]["active"];
                            s16.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][16]["deaths"];
                            s16.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][16]["recovered"];
                        }
                        if (s17 != null)
                        {
                            s17.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][17]["state"];
                            s17.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][17]["active"];
                            s17.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][17]["deaths"];
                            s17.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][17]["recovered"];
                        }
                        if (s18 != null)
                        {
                            s18.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][18]["state"];
                            s18.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][18]["active"];
                            s18.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][18]["deaths"];
                            s18.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][18]["recovered"];
                        }
                        if (s19 != null)
                        {
                            s19.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][19]["state"];
                            s19.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][19]["active"];
                            s19.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][19]["deaths"];
                            s19.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][19]["recovered"];
                        }
                        if (s20 != null)
                        {
                            s20.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][20]["state"];
                            s20.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][20]["active"];
                            s20.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][20]["deaths"];
                            s20.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][20]["recovered"];
                        }
                        if (s21 != null)
                        {
                            s21.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][21]["state"];
                            s21.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][21]["active"];
                            s21.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][21]["deaths"];
                            s21.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][21]["recovered"];
                        }
                        if (s22 != null)
                        {
                            s22.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][22]["state"];
                            s22.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][22]["active"];
                            s22.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][22]["deaths"];
                            s22.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][22]["recovered"];
                        }
                        if (s23 != null)
                        {
                            s23.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][23]["state"];
                            s23.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][23]["active"];
                            s23.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][23]["deaths"];
                            s23.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][23]["recovered"];
                        }
                        // if(s24!=null)
                        // {
                        //     s24.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][24]["state"];
                        //     s24.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][24]["active"];
                        //     s24.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][24]["deaths"];
                        // }
                        if (s25 != null)
                        {
                            s25.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][25]["state"];
                            s25.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][25]["active"];
                            s25.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][25]["deaths"];
                            s25.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][25]["recovered"];
                        }
                        if (s26 != null)
                        {
                            s26.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][26]["state"];
                            s26.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][26]["active"];
                            s26.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][26]["deaths"];
                            s26.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][26]["recovered"];
                        }
                        // if(s27!=null)
                        // {
                        //     s27.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][27]["state"];
                        //     s27.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][27]["active"];
                        //     s27.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][27]["deaths"];
                        // }
                        if (s28 != null)
                        {
                            s28.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][28]["state"];
                            s28.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][28]["active"];
                            s28.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][28]["deaths"];
                            s28.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][28]["recovered"];
                        }
                        if (s29 != null)
                        {
                            s29.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][29]["state"];
                            s29.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][29]["active"];
                            s29.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][29]["deaths"];
                            s29.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][29]["recovered"];
                        }
                        if (s30 != null)
                        {
                            s30.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][30]["state"];
                            s30.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][30]["active"];
                            s30.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][30]["deaths"];
                            s30.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][30]["recovered"];
                        }
                        if (s31 != null)
                        {
                            s31.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][31]["state"];
                            s31.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][31]["active"];
                            s31.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][31]["deaths"];
                            s31.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][31]["recovered"];
                        }
                        if (s32 != null)
                        {
                            s32.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][32]["state"];
                            s32.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][32]["active"];
                            s32.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][32]["deaths"];
                            s32.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][32]["recovered"];
                        }
                        if (s34 != null)
                        {
                            s34.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][34]["state"];
                            s34.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][34]["active"];
                            s34.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][34]["deaths"];
                            s34.gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().text = jsonData["statewise"][34]["recovered"];
                        }
                        // if(s35!=null)
                        // {
                        //     s35.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][35]["state"];
                        //     s35.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][35]["active"];
                        //     s35.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][35]["deaths"];
                        // }if(s36!=null)
                        // {
                        //     s36.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][36]["state"];
                        //     s36.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][36]["active"];
                        //     s36.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().text=jsonData["statewise"][36]["deaths"];
                        // }

                        print(jsonData["statewise"][1]["active"]);
                        //mystatelist = JsonUtility.FromJson<statelist>()();


                    }
                }
            }

        }

    }


    // Update is called once per frame


}
