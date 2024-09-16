<window>
    <cfml version="1.0" minspk="SPS3"/>
    <settings>
        <title>CrossForms Test2</title>
        <width>580</width>
        <height>560</height>
    </settings>
    <button x="40" y="90" width="120" height="30" id="butn1" click="click_func">Set a new title</button>
    <label x="40" y="40" width="90" height="20" id="label1">Test1</label>
    <label x="45" y="125" width="90" height="20" id="label2">Test2</label>
    <combobox list="Java;C#;C++;Python" base="1" x="45" y="150"
              width="100" height="20" callback="onLangChoose" id="combo1"/>
</window>