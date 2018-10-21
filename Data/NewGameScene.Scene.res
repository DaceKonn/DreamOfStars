<root dataType="Struct" type="Duality.Resources.Scene" id="129723834">
  <assetInfo />
  <globalGravity dataType="Struct" type="Duality.Vector2">
    <X dataType="Float">0</X>
    <Y dataType="Float">33</Y>
  </globalGravity>
  <serializeObj dataType="Array" type="Duality.GameObject[]" id="427169525">
    <item dataType="Struct" type="Duality.GameObject" id="1680149028">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="4281429402">
        <_items dataType="Array" type="Duality.Component[]" id="3754961792" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="1737426246">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">1680149028</gameobj>
          </item>
          <item dataType="Struct" type="Duality.Components.Camera" id="3226535505">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">1680149028</gameobj>
          </item>
          <item dataType="Struct" type="Duality.Components.SoundListener" id="3712801555">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">1680149028</gameobj>
          </item>
        </_items>
        <_size dataType="Int">3</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3609410362" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="2820964320">
            <item dataType="Type" id="262495196" value="Duality.Components.Transform" />
            <item dataType="Type" id="2250877206" value="Duality.Components.Camera" />
            <item dataType="Type" id="2185489736" value="Duality.Components.SoundListener" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="3962463118">
            <item dataType="ObjectRef">1737426246</item>
            <item dataType="ObjectRef">3226535505</item>
            <item dataType="ObjectRef">3712801555</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">1737426246</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="37990140">vgpG5t/wwkqz0Fpcp3dtyQ==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">MainCamera</name>
      <parent />
      <prefabLink dataType="Struct" type="Duality.Resources.PrefabLink" id="3408625946">
        <changes />
        <obj dataType="ObjectRef">1680149028</obj>
        <prefab dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Prefab]]">
          <contentPath dataType="String">Data\MainCamera.Prefab.res</contentPath>
        </prefab>
      </prefabLink>
    </item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
