using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.UI;

public class ObjectsTransformHandler : MonoBehaviour
{
    public bool IsRotated { get; set; }
    public bool IsScaled { get; set; }
    public bool IsDragged { get; set; }

    public bool IsSelect { get; set; } = false;

    [SerializeField] private ObjectsTransformBase scaleObject;
    [SerializeField] private ObjectsTransformBase rotateObject;
    [SerializeField] private ObjectsTransformBase dragObject;
    [SerializeField] private ObjectsTransformBase selectObject;

    private void OnEnable()
    {
        TouchSimulation.Enable();
        scaleObject.TransformEvent.AddListener(OnScale);
        rotateObject.TransformEvent.AddListener(OnRotate);
        dragObject.TransformEvent.AddListener(OnDragging);
        selectObject.TransformEvent.AddListener(OnSelect);
       
    }

    public void SelectObject()
    {
        scaleObject.StartTouch();
        rotateObject.StartTouch();
        dragObject.StartTouch();
    }

    public void DeselectObject()
    {
        scaleObject.StopTouch();
        rotateObject.StopTouch();
        dragObject.StopTouch();
    }

    private void HandleTransform()
    {
        if (!IsSelect) return;
        scaleObject.IsWorking = false;
        dragObject.IsWorking = false;
        rotateObject.IsWorking = false;
       
        if (IsScaled)
        {
           
            scaleObject.IsWorking = true;
           
            return;
        }
 
        if (IsDragged)
        {
            dragObject.IsWorking = true;
           
            return;
        }
       
        if (IsRotated)
        {
            rotateObject.IsWorking = true;
            return;
        }
       
    }

   
    public void OnRotate(bool isRot)
    {
        IsRotated = isRot;
        HandleTransform();
    }

    public void OnScale(bool isScale)
    {
        IsScaled = isScale;
        HandleTransform();
    }
    public void OnSelect(bool isSelect) {
        IsSelect = isSelect;
        HandleTransform();
    }
    public void OnDragging(bool isDarg)
    {
        IsDragged = isDarg;
        HandleTransform();
    }
}


/*
 * {
  "User" : {
    " Mohammad mokhtar" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01203399918",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + A, Q3  + B, Q4  + A, Q4  + D, Q4  + F, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : " Mohammad mokhtar"
    },
    " dr ibrahim shabraay" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01002034412",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q3  + A, Q3  + C, Q4  + C, Q4  + F, Q4  + G, Q4  + B, Q4  + A, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : " dr ibrahim shabraay"
    },
    "Ahmed gamil" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01000958665",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + C, Q4  + C, Q4  + A, Q5  + A, Q6  + A, Q7  + B, ",
      "SurveyResults" : "",
      "Username" : "Ahmed gamil"
    },
    "Mohamed hamed" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01002007166",
      "RecoxibrightResults" : "",
      "Score" : "",
      "SurveyResults" : "",
      "Username" : "Mohamed hamed"
    },
    "Mohamed metwaly" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01064321294",
      "RecoxibrightResults" : "",
      "Score" : "",
      "SurveyResults" : "",
      "Username" : "Mohamed metwaly"
    },
    "Mohamed yousry" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01097075868",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q3  + A, Q4  + A, Q4  + B, Q4  + C, Q4  + H, Q4  + F, Q5  + A, Q6  + C, Q7  + B, ",
      "SurveyResults" : "",
      "Username" : "Mohamed yousry"
    },
    "SAAD ALZAYANI" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01094647229",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + D, Q3  + B, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q4  + F, Q4  + E, Q4  + G, Q4  + H, Q5  + B, Q6  + C, Q7  + B, ",
      "SurveyResults" : "",
      "Username" : "SAAD ALZAYANI"
    },
    "Shady Nady" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01094035238",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + B, Q3  + A, Q3  + B, Q3  + C, Q4  + A, Q4  + B, Q4  + D, Q4  + H, Q4  + E, Q4  + F, Q4  + C, Q4  + G, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "Shady Nady"
    },
    "abdel raouf" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01273563111",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q3  + A, Q3  + C, Q4  + C, Q4  + A, Q4  + B, Q4  + F, Q4  + H, Q4  + G, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "abdel raouf"
    },
    "ahmed abd sattar" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01282613930",
      "RecoxibrightResults" : "",
      "Score" : "6",
      "Survey" : "Q1  + C, Q2  + D, Q3  + C, Q3  + B, Q4  + C, Q4  + A, Q4  + B, Q4  + F, Q4  + D, Q4  + E, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ahmed abd sattar"
    },
    "ahmed abdel aala mahdy" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01060988558",
      "Recoxibright" : "Q1  + A, Q1  + A, Q1  + A, ",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + A, Q3  + B, Q3  + C, Q4  + D, Q4  + C, Q4  + A, Q5  + A, Q6  + C, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ahmed abdel aala mahdy"
    },
    "ahmed alsalaly" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01022228456",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q4  + C, Q4  + A, Q4  + F, Q4  + B, Q4  + H, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ahmed alsalaly"
    },
    "ahmed elnoqeity" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01003315306",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + C, Q4  + C, Q4  + A, Q4  + B, Q4  + G, Q4  + H, Q4  + D, Q4  + F, Q4  + E, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ahmed elnoqeity"
    },
    "ahmed elsayed" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01274260027",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + B, Q4  + C, Q4  + A, Q4  + B, Q4  + D, Q4  + H, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ahmed elsayed"
    },
    "ahmed farag saqr" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01222415383",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + C, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q4  + F, Q4  + E, Q4  + G, Q4  + H, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ahmed farag saqr"
    },
    "ahmed khairy" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01002018792",
      "RecoxibrightResults" : "",
      "Score" : "",
      "SurveyResults" : "",
      "Username" : "ahmed khairy"
    },
    "ahmed mohamed" : {
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + B, Q3  + A, Q3  + B, Q4  + B, Q4  + F, Q4  + A, Q4  + C, Q5  + A, Q6  + A, Q7  + A, "
    },
    "ahmed rashed" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + C, Q4  + C, Q4  + B, Q4  + A, Q4  + F, Q4  + G, Q4  + D, Q4  + H, Q4  + E, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ahmed rashed"
    },
    "ahmed said" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01224003310",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q3  + C, Q4  + A, Q4  + B, Q4  + C, Q5  + A, Q6  + C, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ahmed said"
    },
    "ahmed saleh" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01000544436",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + B, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q4  + E, Q4  + F, Q4  + G, Q4  + H, Q5  + B, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ahmed saleh"
    },
    "ahmed shemais" : {
      "Elixozolid" : "Q1  + B, Q2  + C, Q3  + A, Q4  + A, Q5  + E, ",
      "ElixozolidResults" : "",
      "PhoneNumber" : "01005559755",
      "RecoxibrightResults" : "",
      "Score" : "11",
      "Survey" : "Q1  + C, Q2  + D, Q3  + B, Q4  + C, Q4  + A, Q4  + B, Q4  + F, Q4  + D, Q4  + E, Q4  + H, Q4  + G, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ahmed shemais"
    },
    "ali elawady" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01009140013",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q3  + C, Q4  + D, Q4  + A, Q4  + C, Q4  + B, Q4  + E, Q4  + F, Q4  + G, Q4  + H, Q5  + B, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ali elawady"
    },
    "amir assem" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01223876767",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + B, Q4  + B, Q4  + A, Q4  + C, Q4  + F, Q4  + G, Q4  + H, Q4  + D, Q4  + E, Q5  + A, Q6  + A, Q7  + B, ",
      "SurveyResults" : "",
      "Username" : "amir assem"
    },
    "ayman mady" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01278977226",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + B, Q4  + H, Q4  + D, Q4  + C, Q4  + A, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ayman mady"
    },
    "bahaa kornah" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01223433418",
      "RecoxibrightResults" : "",
      "Score" : "6",
      "Survey" : "Q2  + A, Q3  + C, Q4  + D, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "bahaa kornah"
    },
    "beshoy atef" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01095518150",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + A, Q2  + C, Q3  + B, Q4  + A, Q4  + C, Q4  + B, Q4  + D, Q4  + H, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "beshoy atef"
    },
    "david nagy" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01206899350",
      "RecoxibrightResults" : "",
      "Score" : "",
      "SurveyResults" : "",
      "Username" : "david nagy"
    },
    "dr abdelkhalik taha" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01002627747",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + A, Q3  + B, Q4  + C, Q4  + A, Q4  + B, Q4  + F, Q4  + D, Q5  + B, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr abdelkhalik taha"
    },
    "dr ahmad asela" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01007822296",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + A, Q3  + B, Q3  + C, Q3  + A, Q4  + H, Q4  + C, Q4  + G, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr ahmad asela"
    },
    "dr ahmad sabry" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01097697432",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + A, Q3  + A, Q4  + A, Q4  + B, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr ahmad sabry"
    },
    "dr basem nada" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01014875786",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q3  + A, Q4  + C, Q4  + B, Q5  + B, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr basem nada"
    },
    "dr hosam eldin" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01003379335",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + D, Q3  + B, Q4  + C, Q5  + A, Q6  + A, Q7  + B, ",
      "SurveyResults" : "",
      "Username" : "dr hosam eldin"
    },
    "dr khaled swailem" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01029354541",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + B, Q3  + C, Q3  + A, Q4  + F, Q4  + D, Q4  + C, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr khaled swailem"
    },
    "dr mahmoud ammar012" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01200769443",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + C, Q3  + B, Q4  + C, Q4  + B, Q4  + A, Q4  + D, Q5  + B, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr mahmoud ammar012"
    },
    "dr mohamed aboel3nin" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01008703007",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + A, Q3  + B, Q3  + A, Q3  + C, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q4  + H, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr mohamed aboel3nin"
    },
    "dr mohamed gamal kotob" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01229767348",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + A, Q3  + B, Q3  + A, Q3  + C, Q4  + D, Q4  + H, Q4  + E, Q4  + C, Q4  + B, Q4  + A, Q5  + B, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr mohamed gamal kotob"
    },
    "dr mohamed mansor" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01024009053",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + B, Q4  + A, Q4  + F, Q4  + B, Q4  + C, Q4  + H, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr mohamed mansor"
    },
    "dr mohamed shabaan" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01065059599",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + A, Q3  + C, Q4  + A, Q4  + C, Q4  + H, Q4  + D, Q5  + A, Q6  + C, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr mohamed shabaan"
    },
    "dr osama nofal" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01005084053",
      "RecoxibrightResults" : "",
      "Score" : "6",
      "Survey" : "Q2  + C, Q3  + B, Q4  + A, Q4  + C, Q4  + B, Q4  + F, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr osama nofal"
    },
    "dr rafaat louis" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01227978162",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + B, Q3  + C, Q3  + A, Q4  + B, Q4  + C, Q4  + F, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr rafaat louis"
    },
    "dr sameh nasry" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01277552330",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + A, Q2  + D, Q3  + B, Q3  + A, Q3  + C, Q4  + A, Q4  + B, Q4  + D, Q4  + C, Q4  + H, Q4  + E, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr sameh nasry"
    },
    "dr taher alaa" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01004859149",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + B, Q4  + A, Q4  + C, Q4  + B, Q4  + D, Q5  + B, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "dr taher alaa"
    },
    "emad abozahra" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01014221221",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + A, Q3  + B, Q3  + C, Q4  + C, Q4  + A, Q4  + B, Q4  + D, Q4  + E, Q4  + F, Q4  + G, Q4  + H, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "emad abozahra"
    },
    "haitham aboaamr" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01111600535",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + A, Q3  + A, Q3  + B, Q3  + C, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q4  + H, Q4  + E, Q5  + A, Q6  + C, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "haitham aboaamr"
    },
    "haroun omran" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01032865393",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + C, Q3  + B, Q3  + A, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q5  + A, Q6  + A, Q7  + B, ",
      "SurveyResults" : "",
      "Username" : "haroun omran"
    },
    "hassan atteya" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01020801383",
      "RecoxibrightResults" : "",
      "Score" : "",
      "SurveyResults" : "",
      "Username" : "hassan atteya"
    },
    "hassan elfiky" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01094720190",
      "RecoxibrightResults" : "",
      "Score" : "",
      "SurveyResults" : "",
      "Username" : "hassan elfiky"
    },
    "hassan nashea" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01140726211",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q4  + C, Q4  + A, Q4  + D, Q4  + F, Q4  + B, Q4  + E, Q4  + G, Q4  + H, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "hassan nashea"
    },
    "hesham hussen" : {
      "Elixozolid" : "Q1  + A, Q2  + A, Q3  + A, Q4  + A, Q5  + E, ",
      "ElixozolidResults" : "",
      "PhoneNumber" : "01003703580",
      "Recoxibright" : "Q1  + A, Q1  + D, Q2  + A, Q3  + A, Q3  + C, Q3  + D, Q4  + A, Q4  + B, Q4  + E, Q5  + A, Q5  + C, Q5  + D, ",
      "RecoxibrightResults" : "",
      "Score" : "8",
      "SurveyResults" : "",
      "Username" : "hesham hussen"
    },
    "hossam etman" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01125253250",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + C, Q4  + A, Q4  + C, Q4  + B, Q4  + F, Q4  + H, Q4  + D, Q4  + E, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "hossam etman"
    },
    "hossam mohamed" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01151363450",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q4  + E, Q4  + F, Q4  + G, Q4  + H, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "hossam mohamed"
    },
    "ibrahim bakr" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01001477678",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + A, Q3  + B, Q3  + C, Q4  + A, Q4  + C, Q4  + G, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "ibrahim bakr"
    },
    "islam taalb" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01007574531",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + C, Q3  + B, Q4  + C, Q4  + A, Q4  + B, Q4  + F, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "islam taalb"
    },
    "maher Mohamed" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01061188338",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + B, Q3  + C, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q4  + E, Q4  + F, Q4  + G, Q4  + H, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "maher Mohamed"
    },
    "mahmoud adel" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01007296693",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "SurveyResults" : "",
      "Username" : "mahmoud adel"
    },
    "mahmoud hamouda" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01023296171",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "SurveyResults" : "",
      "Username" : "mahmoud hamouda"
    },
    "mahmoud yassin" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01090863425",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q4  + C, Q4  + B, Q4  + F, Q4  + A, Q4  + D, Q4  + E, Q4  + H, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "mahmoud yassin"
    },
    "mahoud awd" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01020103570",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + D, Q3  + A, Q3  + B, Q4  + A, Q4  + B, Q4  + C, Q4  + H, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "mahoud awd"
    },
    "mamdouh omran" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01001743423",
      "Recoxibright" : "Q1  + B, ",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + A, Q3  + B, Q3  + C, Q4  + A, Q4  + C, Q4  + B, Q4  + D, Q4  + E, Q4  + F, Q4  + G, Q4  + H, Q5  + A, Q6  + B, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "mamdouh omran"
    },
    "mamdouh soliman" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01222181511",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + A, Q3  + B, Q3  + C, Q4  + D, Q4  + A, Q4  + B, Q4  + C, Q4  + F, Q4  + E, Q4  + H, Q4  + G, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "mamdouh soliman"
    },
    "mario mikhael" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01208025076",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + A, Q3  + B, Q3  + C, Q4  + A, Q4  + C, Q4  + B, Q4  + H, Q4  + G, Q4  + F, Q4  + E, Q4  + D, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "mario mikhael"
    },
    "mina latif" : {
      "Elixozolid" : "Q1  + A, Q2  + A, Q3  + A, Q4  + A, Q5  + E, ",
      "ElixozolidResults" : "",
      "PhoneNumber" : "0127790852",
      "RecoxibrightResults" : "",
      "Score" : "11",
      "Survey" : "Q1  + B, Q2  + C, Q2  + D, Q3  + B, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q4  + F, Q4  + G, Q4  + H, Q5  + A, Q6  + C, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "mina latif"
    },
    "mohamed abdel gawad" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01027068800",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, Q4  + A, Q4  + B, Q4  + F, Q4  + D, Q4  + C, Q4  + E, Q4  + G, Q4  + H, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "mohamed abdel gawad"
    },
    "mohamed abo elsoud" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01060034000",
      "RecoxibrightResults" : "",
      "Score" : "",
      "SurveyResults" : "",
      "Username" : "mohamed abo elsoud"
    },
    "mohamed atteya" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01555557365",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + A, Q3  + A, Q3  + B, Q3  + C, Q4  + A, Q4  + C, Q4  + B, Q4  + D, Q4  + F, Q4  + G, Q4  + E, Q4  + H, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "mohamed atteya"
    },
    "mohamed hammed mohamed" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01007701087",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + B, Q3  + A, Q3  + C, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q5  + A, Q6  + C, Q7  + B, ",
      "SurveyResults" : "",
      "Username" : "mohamed hammed mohamed"
    },
    "mohamed saleh" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01223679496",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + A, Q3  + B, Q3  + C, Q4  + A, Q4  + F, Q4  + C, Q4  + D, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "mohamed saleh"
    },
    "mohamed yehia zakaria" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01025262629",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + A, Q3  + B, Q3  + C, Q4  + C, Q4  + B, Q4  + A, Q4  + F, Q4  + D, Q4  + E, Q4  + G, Q4  + H, Q5  + A, Q6  + A, Q7  + B, ",
      "SurveyResults" : "",
      "Username" : "mohamed yehia zakaria"
    },
    "moshreer ramsis" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01222800589",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "SurveyResults" : "",
      "Username" : "moshreer ramsis"
    },
    "osama nagy " : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01095678774",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + B, Q2  + B, Q3  + B, Q4  + A, Q4  + D, Q4  + C, Q4  + B, Q4  + F, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "osama nagy "
    },
    "sherif el desouky" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01015976699",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + A, Q3  + B, Q3  + C, Q4  + A, Q4  + B, Q4  + C, Q4  + D, Q4  + E, Q4  + F, Q5  + A, Q6  + A, Q7  + A, ",
      "SurveyResults" : "",
      "Username" : "sherif el desouky"
    },
    "sherif hashem" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01069555092",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + C, Q3  + A, Q3  + B, Q3  + C, Q4  + A, Q4  + B, Q4  + C, Q4  + F, Q4  + D, Q4  + H, Q5  + A, Q6  + A, Q7  + B, ",
      "SurveyResults" : "",
      "Username" : "sherif hashem"
    },
    "wadea ramsis" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01221042630",
      "RecoxibrightResults" : "",
      "Score" : "7",
      "Survey" : "Q1  + C, Q2  + D, Q3  + C, Q3  + A, Q3  + B, Q4  + A, Q4  + B, Q4  + C, Q4  + G, Q5  + A, Q6  + B, Q7  + B, ",
      "SurveyResults" : "",
      "Username" : "wadea ramsis"
    },
    "yousif ibrahim bekhit" : {
      "ElixozolidResults" : "",
      "PhoneNumber" : "01099409009",
      "Recoxibright" : "Q2  + A, Q3  + A, Q3  + C, ",
      "RecoxibrightResults" : "",
      "Score" : "4",
      "Survey" : "Q1  + C, Q2  + C, Q3  + B, ",
      "SurveyResults" : "",
      "Username" : "yousif ibrahim bekhit"
    }
  }
}*/