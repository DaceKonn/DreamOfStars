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
          <item dataType="Struct" type="Duality.Components.SoundListener" id="3712801555">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">1680149028</gameobj>
          </item>
          <item dataType="Struct" type="Duality.Components.Camera" id="3226535505">
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
        <changes dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Resources.PrefabLink+VarMod]]" id="2562303744">
          <_items dataType="Array" type="Duality.Resources.PrefabLink+VarMod[]" id="1637536412" length="4">
            <item dataType="Struct" type="Duality.Resources.PrefabLink+VarMod">
              <childIndex dataType="Struct" type="System.Collections.Generic.List`1[[System.Int32]]" id="3874075848">
                <_items dataType="Array" type="System.Int32[]" id="1354760812"></_items>
                <_size dataType="Int">0</_size>
              </childIndex>
              <componentType dataType="ObjectRef">262495196</componentType>
              <prop dataType="MemberInfo" id="3171764958" value="P:Duality.Components.Transform:RelativeAngle" />
              <val dataType="Float">0</val>
            </item>
            <item dataType="Struct" type="Duality.Resources.PrefabLink+VarMod">
              <childIndex dataType="Struct" type="System.Collections.Generic.List`1[[System.Int32]]" id="2789341492">
                <_items dataType="ObjectRef">1354760812</_items>
                <_size dataType="Int">0</_size>
              </childIndex>
              <componentType dataType="ObjectRef">262495196</componentType>
              <prop dataType="MemberInfo" id="1280278306" value="P:Duality.Components.Transform:RelativePos" />
              <val dataType="Struct" type="Duality.Vector3">
                <X dataType="Float">0</X>
                <Y dataType="Float">0</Y>
                <Z dataType="Float">-1500</Z>
              </val>
            </item>
          </_items>
          <_size dataType="Int">2</_size>
        </changes>
        <obj dataType="ObjectRef">1680149028</obj>
        <prefab dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Prefab]]">
          <contentPath dataType="String">Data\MainCamera.Prefab.res</contentPath>
        </prefab>
      </prefabLink>
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="4115179617">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="94735267">
        <_items dataType="Array" type="Duality.Component[]" id="2108056422">
          <item dataType="Struct" type="Duality.Components.Transform" id="4172456835">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">4115179617</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3" />
            <posAbs dataType="Struct" type="Duality.Vector3" />
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Plugins.Tilemaps.Tilemap" id="3320825054">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">4115179617</gameobj>
            <tileData dataType="Struct" type="Duality.Plugins.Tilemaps.TilemapData" id="1383447906" custom="true">
              <body>
                <version dataType="Int">3</version>
                <data dataType="Array" type="System.Byte[]" id="2072028048">H4sIAAAAAAAEAO3TsQ0AIAwDQZMZGID9p6ShQUoPev01VkrLykoyI0nSY6MLkNOorgukugCh70f/P0mSPrIB9ZohYIgRAAA=</data>
              </body>
            </tileData>
            <tileset dataType="Struct" type="Duality.ContentRef`1[[Duality.Plugins.Tilemaps.Tileset]]">
              <contentPath dataType="String">Data\tilset_0_big.Tileset.res</contentPath>
            </tileset>
          </item>
          <item dataType="Struct" type="Duality.Plugins.Tilemaps.TilemapRenderer" id="694245415">
            <active dataType="Bool">true</active>
            <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">255</B>
              <G dataType="Byte">255</G>
              <R dataType="Byte">255</R>
            </colorTint>
            <externalTilemap />
            <gameobj dataType="ObjectRef">4115179617</gameobj>
            <offset dataType="Float">0</offset>
            <origin dataType="Enum" type="Duality.Alignment" name="Center" value="0" />
            <tileDepthMode dataType="Enum" type="Duality.Plugins.Tilemaps.TileDepthOffsetMode" name="Flat" value="0" />
            <tileDepthOffset dataType="Int">0</tileDepthOffset>
            <tileDepthScale dataType="Float">0.01</tileDepthScale>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
          <item dataType="Struct" type="DreamOfStars.Components.MapBuilderComponent" id="2309094516">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">4115179617</gameobj>
          </item>
        </_items>
        <_size dataType="Int">4</_size>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="4059442040" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="1796581577">
            <item dataType="ObjectRef">262495196</item>
            <item dataType="Type" id="1241682574" value="Duality.Plugins.Tilemaps.TilemapRenderer" />
            <item dataType="Type" id="1382328394" value="Duality.Plugins.Tilemaps.Tilemap" />
            <item dataType="Type" id="4125069758" value="DreamOfStars.Components.MapBuilderComponent" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="884940352">
            <item dataType="ObjectRef">4172456835</item>
            <item dataType="ObjectRef">694245415</item>
            <item dataType="ObjectRef">3320825054</item>
            <item dataType="ObjectRef">2309094516</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">4172456835</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="4165502187">+gVpcyVVCkWt2INW6O5ylw==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">MapBuilderComponent</name>
      <parent />
      <prefabLink />
    </item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
