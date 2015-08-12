// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.maps.providers {
public abstract class TiledProvider: global::com.codename1.maps.providers.MapProvider {
public global::java.lang.String _f_1url;

private global::com.codename1.ui.geom.Point _f_1tileNo;

public int _f_1zoomLevel;

public void @this(global::java.lang.String n1, global::com.codename1.maps.Projection n2, global::com.codename1.ui.geom.Dimension n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.providers.TiledProvider: void <init>(java.lang.String, com.codename1.maps.Projection, com.codename1.ui.geom.Dimension)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::com.codename1.maps.providers.MapProvider) _r0_o).@this((global::com.codename1.maps.Projection) _r2_o, (global::com.codename1.ui.geom.Dimension) _r3_o);
    ((global::com.codename1.maps.providers.TiledProvider) _r0_o)._f_1url = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.providers.TiledProvider: void <init>(java.lang.String, com.codename1.maps.Projection, com.codename1.ui.geom.Dimension)]
}

public virtual global::System.Object url(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.providers.TiledProvider: java.lang.String url(int, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r3_o = this;
    _r4.i = n1;
    _r5.i = n2;
    _r6.i = n3;
    // Value=/
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    _r0_o = new global::java.lang.StringBuilder();
    _r1_o = ((global::com.codename1.maps.providers.TiledProvider) _r3_o)._f_1url;
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    // Value=/
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    ((global::java.lang.StringBuilder) _r0_o).append((int) _r4.i);
    // Value=/
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    ((global::java.lang.StringBuilder) _r0_o).append((int) _r5.i);
    // Value=/
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    ((global::java.lang.StringBuilder) _r0_o).append((int) _r6.i);
    // Value=.png
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.maps.providers.TiledProvider: java.lang.String url(int, int, int)]
}

private int tileNo(double n1, double n2, double n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.providers.TiledProvider: int tileNo(double, double, double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    _r2_o = this;
    _r3.d = n1;
    _r5.d = n2;
    _r7.d = n3;
    _r0.d = _r3.d - _r5.d;
    _r0.d = _r0.d / _r7.d;
    _r0.i = (int) _r0.d;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.maps.providers.TiledProvider: int tileNo(double, double, double)]
}

private double tileCoord(int n1, double n2, double n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.providers.TiledProvider: double tileCoord(int, double, double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    _r2_o = this;
    _r3.i = n1;
    _r4.d = n2;
    _r6.d = n3;
    _r0.d = (double) _r3.i;
    _r0.d = _r0.d * _r6.d;
    _r0.d = _r0.d + _r4.d;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.maps.providers.TiledProvider: double tileCoord(int, double, double)]
}

public override global::System.Object scale(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.providers.TiledProvider: com.codename1.maps.Coord scale(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    _r13_o = this;
    _r14.i = n1;
    _r11.d = 1.0D;
    _r0.i = 1;
    _r6.i = _r0.i << (0x1f & _r14.i);
    _r0_o = ((global::com.codename1.maps.providers.TiledProvider) _r13_o).projection();
    _r0_o = ((global::com.codename1.maps.Projection) _r0_o).extent();
    _r7.d = ((global::com.codename1.maps.BoundingBox) _r0_o).longitudeDifference();
    _r7.d = _r7.d * _r11.d;
    _r9.d = (double) _r6.i;
    _r7.d = _r7.d / _r9.d;
    _r0_o = ((global::com.codename1.maps.providers.TiledProvider) _r13_o).tileSize();
    _r0.i = ((global::com.codename1.ui.geom.Dimension) _r0_o).getWidth();
    _r9.d = (double) _r0.i;
    _r3.d = _r7.d / _r9.d;
    _r0_o = ((global::com.codename1.maps.providers.TiledProvider) _r13_o).projection();
    _r0_o = ((global::com.codename1.maps.Projection) _r0_o).extent();
    _r7.d = ((global::com.codename1.maps.BoundingBox) _r0_o).latitudeDifference();
    _r7.d = _r7.d * _r11.d;
    _r9.d = (double) _r6.i;
    _r7.d = _r7.d / _r9.d;
    _r0_o = ((global::com.codename1.maps.providers.TiledProvider) _r13_o).tileSize();
    _r0.i = ((global::com.codename1.ui.geom.Dimension) _r0_o).getHeight();
    _r9.d = (double) _r0.i;
    _r1.d = _r7.d / _r9.d;
    _r0_o = new global::com.codename1.maps.Coord();
    _r5.i = 0;
    ((global::com.codename1.maps.Coord) _r0_o).@this((double) _r1.d, (double) _r3.d, 0!=_r5.i);
    return (global::com.codename1.maps.Coord) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.maps.providers.TiledProvider: com.codename1.maps.Coord scale(int)]
}

private global::System.Object tileNo(global::com.codename1.maps.Coord n1, global::com.codename1.maps.Coord n2, global::com.codename1.maps.Coord n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.providers.TiledProvider: com.codename1.ui.geom.Point tileNo(com.codename1.maps.Coord, com.codename1.maps.Coord, com.codename1.maps.Coord)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    _r9_o = this;
    _r10_o = n1;
    _r11_o = n2;
    _r12_o = n3;
    _r7_o = new global::com.codename1.ui.geom.Point();
    _r1.d = ((global::com.codename1.maps.Coord) _r10_o).getLongitude();
    _r3.d = ((global::com.codename1.maps.Coord) _r11_o).getLongitude();
    _r5.d = ((global::com.codename1.maps.Coord) _r12_o).getLongitude();
    _r0_o = _r9_o;
    _r8.i = ((global::com.codename1.maps.providers.TiledProvider) _r0_o).tileNo((double) _r1.d, (double) _r3.d, (double) _r5.d);
    _r1.d = ((global::com.codename1.maps.Coord) _r10_o).getLatitude();
    _r3.d = ((global::com.codename1.maps.Coord) _r11_o).getLatitude();
    _r5.d = ((global::com.codename1.maps.Coord) _r12_o).getLatitude();
    _r0_o = _r9_o;
    _r0.i = ((global::com.codename1.maps.providers.TiledProvider) _r0_o).tileNo((double) _r1.d, (double) _r3.d, (double) _r5.d);
    ((global::com.codename1.ui.geom.Point) _r7_o).@this((int) _r8.i, (int) _r0.i);
    return (global::com.codename1.ui.geom.Point) _r7_o;
//XMLVM_END_WRAPPER[com.codename1.maps.providers.TiledProvider: com.codename1.ui.geom.Point tileNo(com.codename1.maps.Coord, com.codename1.maps.Coord, com.codename1.maps.Coord)]
}

private global::System.Object tileCoord(global::com.codename1.ui.geom.Point n1, global::com.codename1.maps.Coord n2, global::com.codename1.maps.Coord n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.providers.TiledProvider: com.codename1.maps.Coord tileCoord(com.codename1.ui.geom.Point, com.codename1.maps.Coord, com.codename1.maps.Coord)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    _r9_o = this;
    _r10_o = n1;
    _r11_o = n2;
    _r12_o = n3;
    _r6_o = new global::com.codename1.maps.Coord();
    _r1.i = ((global::com.codename1.ui.geom.Point) _r10_o).getY();
    _r2.d = ((global::com.codename1.maps.Coord) _r11_o).getLatitude();
    _r4.d = ((global::com.codename1.maps.Coord) _r12_o).getLatitude();
    _r0_o = _r9_o;
    _r7.d = ((global::com.codename1.maps.providers.TiledProvider) _r0_o).tileCoord((int) _r1.i, (double) _r2.d, (double) _r4.d);
    _r1.i = ((global::com.codename1.ui.geom.Point) _r10_o).getX();
    _r2.d = ((global::com.codename1.maps.Coord) _r11_o).getLongitude();
    _r4.d = ((global::com.codename1.maps.Coord) _r12_o).getLongitude();
    _r0_o = _r9_o;
    _r3.d = ((global::com.codename1.maps.providers.TiledProvider) _r0_o).tileCoord((int) _r1.i, (double) _r2.d, (double) _r4.d);
    _r5.i = 1;
    _r0_o = _r6_o;
    _r1.d = _r7.d;
    ((global::com.codename1.maps.Coord) _r0_o).@this((double) _r1.d, (double) _r3.d, 0!=_r5.i);
    return (global::com.codename1.maps.Coord) _r6_o;
//XMLVM_END_WRAPPER[com.codename1.maps.providers.TiledProvider: com.codename1.maps.Coord tileCoord(com.codename1.ui.geom.Point, com.codename1.maps.Coord, com.codename1.maps.Coord)]
}

public override global::System.Object bboxFor(global::com.codename1.maps.Coord n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.providers.TiledProvider: com.codename1.maps.BoundingBox bboxFor(com.codename1.maps.Coord, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r19_o = null;
    global::System.Object _r20_o = null;
    global::org.xmlvm._nElement _r21;
    _r19_o = this;
    _r20_o = n1;
    _r21.i = n2;
    _r0.i = _r21.i;
    _r1_o = _r19_o;
    ((global::com.codename1.maps.providers.TiledProvider) _r1_o)._f_1zoomLevel = _r0.i;
    _r0_o = _r19_o;
    _r1.i = _r21.i;
    _r12_o = ((global::com.codename1.maps.providers.TiledProvider) _r0_o).scale((int) _r1.i);
    _r14_o = ((global::com.codename1.maps.providers.TiledProvider) _r19_o).tileSize();
    _r15.d = ((global::com.codename1.maps.Coord) _r12_o).getLongitude();
    _r10.i = ((global::com.codename1.ui.geom.Dimension) _r14_o).getWidth();
    _r0.i = _r10.i;
    _r0.d = (double) _r0.i;
    _r17.d = _r0.d;
    _r8.d = _r15.d * _r17.d;
    _r15.d = ((global::com.codename1.maps.Coord) _r12_o).getLatitude();
    _r10.i = ((global::com.codename1.ui.geom.Dimension) _r14_o).getHeight();
    _r0.i = _r10.i;
    _r0.d = (double) _r0.i;
    _r17.d = _r0.d;
    _r6.d = _r15.d * _r17.d;
    _r5_o = new global::com.codename1.maps.Coord();
    _r10.i = 0;
    ((global::com.codename1.maps.Coord) _r5_o).@this((double) _r6.d, (double) _r8.d, 0!=_r10.i);
    _r10_o = ((global::com.codename1.maps.providers.TiledProvider) _r19_o).projection();
    _r10_o = ((global::com.codename1.maps.Projection) _r10_o).extent();
    _r10_o = ((global::com.codename1.maps.BoundingBox) _r10_o).getSouthWest();
    _r0_o = _r19_o;
    _r1_o = _r20_o;
    _r2_o = _r10_o;
    _r3_o = _r5_o;
    _r10_o = ((global::com.codename1.maps.providers.TiledProvider) _r0_o).tileNo((global::com.codename1.maps.Coord) _r1_o, (global::com.codename1.maps.Coord) _r2_o, (global::com.codename1.maps.Coord) _r3_o);
    _r0_o = _r10_o;
    _r1_o = _r19_o;
    ((global::com.codename1.maps.providers.TiledProvider) _r1_o)._f_1tileNo = (global::com.codename1.ui.geom.Point) _r0_o;
    _r0_o = _r19_o;
    _r0_o = ((global::com.codename1.maps.providers.TiledProvider) _r0_o)._f_1tileNo;
    _r10_o = _r0_o;
    _r11_o = ((global::com.codename1.maps.providers.TiledProvider) _r19_o).projection();
    _r11_o = ((global::com.codename1.maps.Projection) _r11_o).extent();
    _r11_o = ((global::com.codename1.maps.BoundingBox) _r11_o).getSouthWest();
    _r0_o = _r19_o;
    _r1_o = _r10_o;
    _r2_o = _r11_o;
    _r3_o = _r5_o;
    _r13_o = ((global::com.codename1.maps.providers.TiledProvider) _r0_o).tileCoord((global::com.codename1.ui.geom.Point) _r1_o, (global::com.codename1.maps.Coord) _r2_o, (global::com.codename1.maps.Coord) _r3_o);
    _r15.d = ((global::com.codename1.maps.Coord) _r5_o).getLatitude();
    _r17.d = ((global::com.codename1.maps.Coord) _r5_o).getLongitude();
    _r0_o = _r13_o;
    _r1.d = _r15.d;
    _r3.d = _r17.d;
    _r11_o = ((global::com.codename1.maps.Coord) _r0_o).translate((double) _r1.d, (double) _r3.d);
    _r10_o = new global::com.codename1.maps.BoundingBox();
    ((global::com.codename1.maps.BoundingBox) _r10_o).@this((global::com.codename1.maps.Coord) _r13_o, (global::com.codename1.maps.Coord) _r11_o);
    return (global::com.codename1.maps.BoundingBox) _r10_o;
//XMLVM_END_WRAPPER[com.codename1.maps.providers.TiledProvider: com.codename1.maps.BoundingBox bboxFor(com.codename1.maps.Coord, int)]
}

public override global::System.Object tileFor(global::com.codename1.maps.BoundingBox n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.providers.TiledProvider: com.codename1.maps.Tile tileFor(com.codename1.maps.BoundingBox)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r5.i = 1;
    _r1.i = ((global::com.codename1.maps.providers.TiledProvider) _r6_o)._f_1zoomLevel;
    _r2_o = ((global::com.codename1.maps.providers.TiledProvider) _r6_o)._f_1tileNo;
    _r2.i = ((global::com.codename1.ui.geom.Point) _r2_o).getX();
    _r3.i = ((global::com.codename1.maps.providers.TiledProvider) _r6_o)._f_1zoomLevel;
    _r3.i = _r5.i << (0x1f & _r3.i);
    _r4_o = ((global::com.codename1.maps.providers.TiledProvider) _r6_o)._f_1tileNo;
    _r4.i = ((global::com.codename1.ui.geom.Point) _r4_o).getY();
    _r3.i = _r3.i - _r4.i;
    _r3.i = _r3.i - _r5.i;
    _r0_o = ((global::com.codename1.maps.providers.TiledProvider) _r6_o).url((int) _r1.i, (int) _r2.i, (int) _r3.i);
    _r1_o = new global::com.codename1.maps.ProxyHttpTile();
    _r2_o = ((global::com.codename1.maps.providers.TiledProvider) _r6_o).tileSize();
    ((global::com.codename1.maps.ProxyHttpTile) _r1_o).@this((global::com.codename1.ui.geom.Dimension) _r2_o, (global::com.codename1.maps.BoundingBox) _r7_o, (global::java.lang.String) _r0_o);
    return (global::com.codename1.maps.Tile) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.maps.providers.TiledProvider: com.codename1.maps.Tile tileFor(com.codename1.maps.BoundingBox)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.maps.providers.TiledProvider]
//XMLVM_END_WRAPPER[com.codename1.maps.providers.TiledProvider]

} // end of class: TiledProvider

} // end of namespace: com.codename1.maps.providers
