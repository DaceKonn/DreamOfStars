<root dataType="Struct" type="Duality.Resources.Scene" id="129723834">
  <assetInfo />
  <globalGravity dataType="Struct" type="Duality.Vector2">
    <X dataType="Float">0</X>
    <Y dataType="Float">33</Y>
  </globalGravity>
  <serializeObj dataType="Array" type="Duality.GameObject[]" id="427169525">
    <item dataType="Struct" type="Duality.GameObject" id="3072167001">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3026870011">
        <_items dataType="Array" type="Duality.Component[]" id="656350806" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="3129444219">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">3072167001</gameobj>
          </item>
          <item dataType="Struct" type="Duality.Components.Camera" id="323586182">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">3072167001</gameobj>
          </item>
          <item dataType="Struct" type="Duality.Components.SoundListener" id="809852232">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">3072167001</gameobj>
          </item>
        </_items>
        <_size dataType="Int">3</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="972381096" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="923976465">
            <item dataType="Type" id="1594151662" value="Duality.Components.Transform" />
            <item dataType="Type" id="1830747594" value="Duality.Components.Camera" />
            <item dataType="Type" id="475267294" value="Duality.Components.SoundListener" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="2571207584">
            <item dataType="ObjectRef">3129444219</item>
            <item dataType="ObjectRef">323586182</item>
            <item dataType="ObjectRef">809852232</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">3129444219</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="2418565763">avuTTciJXEuOkamG6exy2w==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">MainCamera</name>
      <parent />
      <prefabLink dataType="Struct" type="Duality.Resources.PrefabLink" id="2956194545">
        <changes />
        <obj dataType="ObjectRef">3072167001</obj>
        <prefab dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Prefab]]">
          <contentPath dataType="String">Data\MainCamera.Prefab.res</contentPath>
        </prefab>
      </prefabLink>
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="2396884108">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3372334210">
        <_items dataType="Array" type="Duality.Component[]" id="1119576720" length="4">
          <item dataType="Struct" type="DreamOfStars.UserInterface.MainMenuUI" id="3770859493">
            <_x003C_IsFullScreen_x003E_k__BackingField dataType="Bool">true</_x003C_IsFullScreen_x003E_k__BackingField>
            <_x003C_NewGameScene_x003E_k__BackingField dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Scene]]">
              <contentPath dataType="String">Data\NewGameScene.Scene.res</contentPath>
            </_x003C_NewGameScene_x003E_k__BackingField>
            <_x003C_Offset_x003E_k__BackingField dataType="Int">1</_x003C_Offset_x003E_k__BackingField>
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">2396884108</gameobj>
          </item>
        </_items>
        <_size dataType="Int">1</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="182026378" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="1123417944">
            <item dataType="Type" id="999105196" value="DreamOfStars.UserInterface.MainMenuUI" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="1338164126">
            <item dataType="ObjectRef">3770859493</item>
          </values>
        </body>
      </compMap>
      <compTransform />
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="1311499780">Qpp5M/dky0Ckn+JTCEfDJA==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">MainMenuUI</name>
      <parent />
      <prefabLink />
    </item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
