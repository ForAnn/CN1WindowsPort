// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.util {
public abstract class ImageIO: global::java.lang.Object {

static ImageIO() {
    // Value=jpeg
    _fFORMAT_1JPEG = new global::java.lang.String();
    _fFORMAT_1JPEG.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)106)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103))}));
    // Value=png
    _fFORMAT_1PNG = new global::java.lang.String();
    _fFORMAT_1PNG.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
}

public static global::java.lang.String _fFORMAT_1JPEG;

public static global::java.lang.String _fFORMAT_1PNG;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.ImageIO: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.ImageIO: void <init>()]
}

public abstract void save(global::java.io.InputStream n1, global::java.io.OutputStream n2, global::java.lang.String n3, int n4, int n5, float n6);

public virtual void save(global::com.codename1.ui.Image n1, global::java.io.OutputStream n2, global::java.lang.String n3, float n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.ImageIO: void save(com.codename1.ui.Image, java.io.OutputStream, java.lang.String, float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r9_o = this;
    _r10_o = n1;
    _r11_o = n2;
    _r12_o = n3;
    _r13.f = n4;
    _r1.i = ((_r10_o != null) && (_r10_o is global::com.codename1.ui.EncodedImage)) ? 1 : 0;
    if (_r1.i == 0) goto label33;
    _r0_o = _r10_o;
    _r0_o = _r0_o;
    _r8_o = _r0_o;
    _r2_o = new global::java.io.ByteArrayInputStream();
    _r1_o = ((global::com.codename1.ui.EncodedImage) _r8_o).getImageData();
    ((global::java.io.ByteArrayInputStream) _r2_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o);
    _r5.i = ((global::com.codename1.ui.EncodedImage) _r8_o).getWidth();
    _r6.i = ((global::com.codename1.ui.EncodedImage) _r8_o).getHeight();
    _r1_o = _r9_o;
    _r3_o = _r11_o;
    _r4_o = _r12_o;
    _r7.f = _r13.f;
    ((global::com.codename1.ui.util.ImageIO) _r1_o).save((global::java.io.InputStream) _r2_o, (global::java.io.OutputStream) _r3_o, (global::java.lang.String) _r4_o, (int) _r5.i, (int) _r6.i, (float) _r7.f);
    label32:;
    return;
    label33:;
    ((global::com.codename1.ui.util.ImageIO) _r9_o).saveImage((global::com.codename1.ui.Image) _r10_o, (global::java.io.OutputStream) _r11_o, (global::java.lang.String) _r12_o, (float) _r13.f);
    goto label32;
//XMLVM_END_WRAPPER[com.codename1.ui.util.ImageIO: void save(com.codename1.ui.Image, java.io.OutputStream, java.lang.String, float)]
}

public virtual void save(global::java.lang.String n1, global::java.io.OutputStream n2, global::java.lang.String n3, int n4, int n5, float n6){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.ImageIO: void save(java.lang.String, java.io.OutputStream, java.lang.String, int, int, float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r8_o = n1;
    _r9_o = n2;
    _r10_o = n3;
    _r11.i = n4;
    _r12.i = n5;
    _r13.f = n6;
    _r0_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r1_o = ((global::com.codename1.io.FileSystemStorage) _r0_o).openInputStream((global::java.lang.String) _r8_o);
    _r0_o = _r7_o;
    _r2_o = _r9_o;
    _r3_o = _r10_o;
    _r4.i = _r11.i;
    _r5.i = _r12.i;
    _r6.f = _r13.f;
    ((global::com.codename1.ui.util.ImageIO) _r0_o).save((global::java.io.InputStream) _r1_o, (global::java.io.OutputStream) _r2_o, (global::java.lang.String) _r3_o, (int) _r4.i, (int) _r5.i, (float) _r6.f);
    global::com.codename1.io.Util.cleanup((global::java.lang.Object) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.ImageIO: void save(java.lang.String, java.io.OutputStream, java.lang.String, int, int, float)]
}

public virtual global::System.Object getImageSize(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.ImageIO: com.codename1.ui.geom.Dimension getImageSize(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r1_o = global::com.codename1.ui.Image.createImage((global::java.lang.String) _r5_o);
    _r0_o = new global::com.codename1.ui.geom.Dimension();
    _r2.i = ((global::com.codename1.ui.Image) _r1_o).getWidth();
    _r3.i = ((global::com.codename1.ui.Image) _r1_o).getHeight();
    ((global::com.codename1.ui.geom.Dimension) _r0_o).@this((int) _r2.i, (int) _r3.i);
    ((global::com.codename1.ui.Image) _r1_o).dispose();
    return (global::com.codename1.ui.geom.Dimension) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.util.ImageIO: com.codename1.ui.geom.Dimension getImageSize(java.lang.String)]
}

public virtual global::System.Object saveAndKeepAspect(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3, int n4, int n5, float n6, bool n7, bool n8){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.ImageIO: java.lang.String saveAndKeepAspect(java.lang.String, java.lang.String, java.lang.String, int, int, float, boolean, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nElement _r16;
    global::System.Object _r16_o = null;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::System.Object _r18_o = null;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r19_o = null;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r20_o = null;
    global::org.xmlvm._nElement _r21;
    global::System.Object _r21_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r13_o = this;
    _r14_o = n1;
    _r15_o = n2;
    _r16_o = n3;
    _r17.i = n4;
    _r18.i = n5;
    _r19.f = n6;
    _r20.i = n7 ? 1 : 0;
    _r21.i = n8 ? 1 : 0;
    _r9_o = ((global::com.codename1.ui.util.ImageIO) _r13_o).getImageSize((global::java.lang.String) _r14_o);
    if (_r20.i == 0) goto label48;
    if (_r21.i == 0) goto label28;
    _r2.i = ((global::com.codename1.ui.geom.Dimension) _r9_o).getHeight();
    _r0.i = _r2.i;
    _r1.i = _r18.i;
    if (_r0.i <= _r1.i) goto label26;
    _r2.i = ((global::com.codename1.ui.geom.Dimension) _r9_o).getWidth();
    _r0.i = _r2.i;
    _r1.i = _r17.i;
    if (_r0.i > _r1.i) goto label48;
    label26:;
    _r2_o = _r14_o;
    label27:;
    return (global::java.lang.String) _r2_o;
    label28:;
    _r2.i = ((global::com.codename1.ui.geom.Dimension) _r9_o).getHeight();
    _r0.i = _r2.i;
    _r1.i = _r18.i;
    if (_r0.i > _r1.i) goto label48;
    _r2.i = ((global::com.codename1.ui.geom.Dimension) _r9_o).getWidth();
    _r0.i = _r2.i;
    _r1.i = _r17.i;
    if (_r0.i > _r1.i) goto label48;
    _r2_o = _r14_o;
    goto label27;
    label48:;
    _r2.i = ((global::com.codename1.ui.geom.Dimension) _r9_o).getWidth();
    _r2.f = (float) _r2.i;
    _r3.i = ((global::com.codename1.ui.geom.Dimension) _r9_o).getHeight();
    _r3.f = (float) _r3.i;
    _r11.f = _r2.f / _r3.f;
    _r0.i = _r17.i;
    _r0.f = (float) _r0.i;
    _r2.f = _r0.f;
    _r2.f = _r2.f / _r11.f;
    _r10.i = (int) _r2.f;
    _r0.i = _r18.i;
    _r0.f = (float) _r0.i;
    _r2.f = _r0.f;
    _r2.f = _r2.f * _r11.f;
    _r12.i = (int) _r2.f;
    if (_r21.i == 0) goto label107;
    _r0.i = _r10.i;
    _r1.i = _r17.i;
    if (_r0.i < _r1.i) goto label104;
    _r18.i = _r10.i;
    label81:;
    _r2_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r4_o = ((global::com.codename1.io.FileSystemStorage) _r2_o).openOutputStream((global::java.lang.String) _r15_o);
    _r2_o = _r13_o;
    _r3_o = _r14_o;
    _r5_o = _r16_o;
    _r6.i = _r17.i;
    _r7.i = _r18.i;
    _r8.f = _r19.f;
    ((global::com.codename1.ui.util.ImageIO) _r2_o).save((global::java.lang.String) _r3_o, (global::java.io.OutputStream) _r4_o, (global::java.lang.String) _r5_o, (int) _r6.i, (int) _r7.i, (float) _r8.f);
    _r2_o = _r15_o;
    goto label27;
    label104:;
    _r17.i = _r12.i;
    goto label81;
    label107:;
    _r0.i = _r10.i;
    _r1.i = _r17.i;
    if (_r0.i <= _r1.i) goto label115;
    _r17.i = _r12.i;
    goto label81;
    label115:;
    _r18.i = _r10.i;
    goto label81;
//XMLVM_END_WRAPPER[com.codename1.ui.util.ImageIO: java.lang.String saveAndKeepAspect(java.lang.String, java.lang.String, java.lang.String, int, int, float, boolean, boolean)]
}

public abstract void saveImage(global::com.codename1.ui.Image n1, global::java.io.OutputStream n2, global::java.lang.String n3, float n4);

public abstract bool isFormatSupported(global::java.lang.String n1);

public static global::System.Object getImageIO(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.ImageIO: com.codename1.ui.util.ImageIO getImageIO()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).getImageIO();
    return (global::com.codename1.ui.util.ImageIO) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.util.ImageIO: com.codename1.ui.util.ImageIO getImageIO()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.ImageIO]
//XMLVM_END_WRAPPER[com.codename1.ui.util.ImageIO]

} // end of class: ImageIO

} // end of namespace: com.codename1.ui.util
