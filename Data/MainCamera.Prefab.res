<root dataType="Struct" type="Duality.Resources.Prefab" id="129723834">
  <assetInfo dataType="Struct" type="Duality.Editor.AssetManagement.AssetInfo" id="427169525">
    <customData />
    <importerId />
    <sourceFileHint />
  </assetInfo>
  <objTree dataType="Struct" type="Duality.GameObject" id="1044728768">
    <active dataType="Bool">true</active>
    <children />
    <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1846444183">
      <_items dataType="Array" type="Duality.Component[]" id="4093897998" length="4">
        <item dataType="Struct" type="Duality.Components.Transform" id="1102005986">
          <active dataType="Bool">true</active>
          <angle dataType="Float">0</angle>
          <angleAbs dataType="Float">0</angleAbs>
          <angleVel dataType="Float">0</angleVel>
          <angleVelAbs dataType="Float">0</angleVelAbs>
          <deriveAngle dataType="Bool">true</deriveAngle>
          <gameobj dataType="ObjectRef">1044728768</gameobj>
          <ignoreParent dataType="Bool">false</ignoreParent>
          <parentTransform />
          <pos dataType="Struct" type="Duality.Vector3">
            <X dataType="Float">0</X>
            <Y dataType="Float">0</Y>
            <Z dataType="Float">-500</Z>
          </pos>
          <posAbs dataType="Struct" type="Duality.Vector3">
            <X dataType="Float">0</X>
            <Y dataType="Float">0</Y>
            <Z dataType="Float">-500</Z>
          </posAbs>
          <scale dataType="Float">1</scale>
          <scaleAbs dataType="Float">1</scaleAbs>
          <vel dataType="Struct" type="Duality.Vector3" />
          <velAbs dataType="Struct" type="Duality.Vector3" />
        </item>
        <item dataType="Struct" type="Duality.Components.Camera" id="2591115245">
          <active dataType="Bool">true</active>
          <farZ dataType="Float">10000</farZ>
          <focusDist dataType="Float">500</focusDist>
          <gameobj dataType="ObjectRef">1044728768</gameobj>
          <nearZ dataType="Float">0</nearZ>
          <passes dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="530125965">
            <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="2898440486" length="4">
              <item dataType="Struct" type="Duality.Components.Camera+Pass" id="3523642624">
                <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba" />
                <clearDepth dataType="Float">1</clearDepth>
                <clearFlags dataType="Enum" type="Duality.Drawing.ClearFlag" name="All" value="3" />
                <input />
                <matrixMode dataType="Enum" type="Duality.Drawing.RenderMatrix" name="PerspectiveWorld" value="0" />
                <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]" />
                <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="AllGroups" value="2147483647" />
              </item>
              <item dataType="Struct" type="Duality.Components.Camera+Pass" id="4056998350">
                <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba" />
                <clearDepth dataType="Float">1</clearDepth>
                <clearFlags dataType="Enum" type="Duality.Drawing.ClearFlag" name="None" value="0" />
                <input />
                <matrixMode dataType="Enum" type="Duality.Drawing.RenderMatrix" name="OrthoScreen" value="1" />
                <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]" />
                <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="All" value="4294967295" />
              </item>
            </_items>
            <_size dataType="Int">2</_size>
          </passes>
          <perspective dataType="Enum" type="Duality.Drawing.PerspectiveMode" name="Parallax" value="1" />
          <priority dataType="Int">0</priority>
          <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="All" value="4294967295" />
        </item>
        <item dataType="Struct" type="Duality.Components.SoundListener" id="3077381295">
          <active dataType="Bool">true</active>
          <gameobj dataType="ObjectRef">1044728768</gameobj>
        </item>
      </_items>
      <_size dataType="Int">3</_size>
    </compList>
    <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="609964736" surrogate="true">
      <header />
      <body>
        <keys dataType="Array" type="System.Object[]" id="2586649629">
          <item dataType="Type" id="3468892390" value="Duality.Components.Transform" />
          <item dataType="Type" id="4105906490" value="Duality.Components.Camera" />
          <item dataType="Type" id="1479470694" value="Duality.Components.SoundListener" />
        </keys>
        <values dataType="Array" type="System.Object[]" id="3411953400">
          <item dataType="ObjectRef">1102005986</item>
          <item dataType="ObjectRef">2591115245</item>
          <item dataType="ObjectRef">3077381295</item>
        </values>
      </body>
    </compMap>
    <compTransform dataType="ObjectRef">1102005986</compTransform>
    <identifier dataType="Struct" type="System.Guid" surrogate="true">
      <header>
        <data dataType="Array" type="System.Byte[]" id="569184439">8sNTyE88rkSzHwQF63rEFw==</data>
      </header>
      <body />
    </identifier>
    <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
    <name dataType="String">MainCamera</name>
    <parent />
    <prefabLink />
  </objTree>
</root>
<!-- XmlFormatterBase Document Separator -->
