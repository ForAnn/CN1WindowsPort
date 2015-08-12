// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.maps {
public class Coord: global::java.lang.Object {

static Coord() {
    @static();
}

private double _flongitude;

private double _flatitude;

private bool _fprojected;

private static double _fDELTA;

public void @this(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: void <init>(double, double)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    _r6_o = this;
    _r7.d = n1;
    _r9.d = n2;
    _r5.i = 0;
    _r0_o = _r6_o;
    _r1.d = _r7.d;
    _r3.d = _r9.d;
    ((global::com.codename1.maps.Coord) _r0_o).@this((double) _r1.d, (double) _r3.d, 0!=_r5.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: void <init>(double, double)]
}

public void @this(double n1, double n2, bool n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: void <init>(double, double, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    _r0_o = this;
    _r1.d = n1;
    _r3.d = n2;
    _r5.i = n3 ? 1 : 0;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.maps.Coord) _r0_o)._flatitude = _r1.d;
    ((global::com.codename1.maps.Coord) _r0_o)._flongitude = _r3.d;
    ((global::com.codename1.maps.Coord) _r0_o)._fprojected = 0!=_r5.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: void <init>(double, double, boolean)]
}

public void @this(global::com.codename1.maps.Coord n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: void <init>(com.codename1.maps.Coord)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    ((global::java.lang.Object) _r2_o).@this();
    _r0.d = ((global::com.codename1.maps.Coord) _r3_o).getLongitude();
    ((global::com.codename1.maps.Coord) _r2_o)._flongitude = _r0.d;
    _r0.d = ((global::com.codename1.maps.Coord) _r3_o).getLatitude();
    ((global::com.codename1.maps.Coord) _r2_o)._flatitude = _r0.d;
    _r0.i = ((global::com.codename1.maps.Coord) _r3_o).isProjected() ? 1 : 0;
    ((global::com.codename1.maps.Coord) _r2_o)._fprojected = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: void <init>(com.codename1.maps.Coord)]
}

public virtual double getLongitude(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: double getLongitude()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.maps.Coord) _r2_o)._flongitude;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: double getLongitude()]
}

public virtual double getLatitude(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: double getLatitude()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.maps.Coord) _r2_o)._flatitude;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: double getLatitude()]
}

public virtual void setLongitude(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: void setLongitude(double)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.d = n1;
    ((global::com.codename1.maps.Coord) _r0_o)._flongitude = _r1.d;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: void setLongitude(double)]
}

public virtual void setLatitude(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: void setLatitude(double)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.d = n1;
    ((global::com.codename1.maps.Coord) _r0_o)._flatitude = _r1.d;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: void setLatitude(double)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    // Value=\173'longitude':
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)123)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 58))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.d = ((global::com.codename1.maps.Coord) _r3_o).getLongitude();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((double) _r1.d);
    // Value=, 'latitude':
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 58))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.d = ((global::com.codename1.maps.Coord) _r3_o).getLatitude();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((double) _r1.d);
    // Value=\175
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)125))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: java.lang.String toString()]
}

public virtual global::System.Object translate(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: com.codename1.maps.Coord translate(double, double)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    _r6_o = this;
    _r7.d = n1;
    _r9.d = n2;
    _r0_o = new global::com.codename1.maps.Coord();
    _r1.d = ((global::com.codename1.maps.Coord) _r6_o).getLatitude();
    _r1.d = _r1.d + _r7.d;
    _r3.d = ((global::com.codename1.maps.Coord) _r6_o).getLongitude();
    _r3.d = _r3.d + _r9.d;
    _r5.i = ((global::com.codename1.maps.Coord) _r6_o).isProjected() ? 1 : 0;
    ((global::com.codename1.maps.Coord) _r0_o).@this((double) _r1.d, (double) _r3.d, 0!=_r5.i);
    return (global::com.codename1.maps.Coord) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: com.codename1.maps.Coord translate(double, double)]
}

public virtual global::System.Object translate(global::com.codename1.maps.Coord n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: com.codename1.maps.Coord translate(com.codename1.maps.Coord)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0.d = ((global::com.codename1.maps.Coord) _r5_o).getLatitude();
    _r2.d = ((global::com.codename1.maps.Coord) _r5_o).getLongitude();
    _r0_o = ((global::com.codename1.maps.Coord) _r4_o).translate((double) _r0.d, (double) _r2.d);
    return (global::com.codename1.maps.Coord) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: com.codename1.maps.Coord translate(com.codename1.maps.Coord)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: boolean equals(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r7_o = this;
    _r8_o = n1;
    _r6.i = 0;
    _r2.i = ((_r8_o != null) && (_r8_o is global::com.codename1.maps.Coord)) ? 1 : 0;
    if (_r2.i != 0) goto label7;
    _r2.i = _r6.i;
    label6:;
    return _r2.i!=0;
    label7:;
    _r0_o = _r8_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r2.d = ((global::com.codename1.maps.Coord) _r7_o)._flongitude;
    _r4.d = ((global::com.codename1.maps.Coord) _r1_o)._flongitude;
    _r2.d = _r2.d - _r4.d;
    _r2.d = global::java.lang.Math.abs((double) _r2.d);
    _r4.d = global::com.codename1.maps.Coord._fDELTA;
    _r2.i = _r2.d > _r4.d ? 1 : (_r2.d == _r4.d ? 0 : -1);
    if (_r2.i >= 0) goto label43;
    _r2.d = ((global::com.codename1.maps.Coord) _r7_o)._flatitude;
    _r4.d = ((global::com.codename1.maps.Coord) _r1_o)._flatitude;
    _r2.d = _r2.d - _r4.d;
    _r2.d = global::java.lang.Math.abs((double) _r2.d);
    _r4.d = global::com.codename1.maps.Coord._fDELTA;
    _r2.i = _r2.d > _r4.d ? 1 : (_r2.d == _r4.d ? 0 : -1);
    if (_r2.i >= 0) goto label43;
    _r2.i = 1;
    goto label6;
    label43:;
    _r2.i = _r6.i;
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    _r7_o = this;
    _r6.i = 32;
    _r0.i = 5;
    _r1.i = _r0.i * 17;
    _r1.d = ((global::com.codename1.maps.Coord) _r7_o)._flongitude;
    _r1.l = global::java.lang.Double.doubleToLongBits((double) _r1.d);
    _r3.d = ((global::com.codename1.maps.Coord) _r7_o)._flongitude;
    _r3.l = global::java.lang.Double.doubleToLongBits((double) _r3.d);
    _r3.l = (long) (((ulong) _r3.l) >> (0x3f & (_r6.i)));
    _r1.l = _r1.l ^ _r3.l;
    _r1.i = (int) _r1.l;
    _r0.i = _r1.i + 85;
    _r1.i = _r0.i * 17;
    _r2.d = ((global::com.codename1.maps.Coord) _r7_o)._flatitude;
    _r2.l = global::java.lang.Double.doubleToLongBits((double) _r2.d);
    _r4.d = ((global::com.codename1.maps.Coord) _r7_o)._flatitude;
    _r4.l = global::java.lang.Double.doubleToLongBits((double) _r4.d);
    _r4.l = (long) (((ulong) _r4.l) >> (0x3f & (_r6.i)));
    _r2.l = _r2.l ^ _r4.l;
    _r2.i = (int) _r2.l;
    _r0.i = _r1.i + _r2.i;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: int hashCode()]
}

public virtual bool isProjected(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: boolean isProjected()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.maps.Coord) _r1_o)._fprojected ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: boolean isProjected()]
}

public virtual void setProjected(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: void setProjected(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.maps.Coord) _r0_o)._fprojected = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: void setProjected(boolean)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    _r0.d = 1.0E-7D;
    global::com.codename1.maps.Coord._fDELTA = _r0.d;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.Coord: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.maps.Coord]
//XMLVM_END_WRAPPER[com.codename1.maps.Coord]

} // end of class: Coord

} // end of namespace: com.codename1.maps
