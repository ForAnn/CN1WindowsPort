// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.gzip {
public class GZIPInputStream: global::com.codename1.io.gzip.InflaterInputStream {
public void @this(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream: void <init>(java.io.InputStream)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 512;
    _r1.i = 1;
    ((global::com.codename1.io.gzip.GZIPInputStream) _r2_o).@this((global::java.io.InputStream) _r3_o, (int) _r0.i, 0!=_r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream: void <init>(java.io.InputStream)]
}

public void @this(global::java.io.InputStream n1, int n2, bool n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream: void <init>(java.io.InputStream, int, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2;
    _r5.i = n3 ? 1 : 0;
    _r0_o = new global::com.codename1.io.gzip.Inflater();
    _r1.i = 31;
    ((global::com.codename1.io.gzip.Inflater) _r0_o).@this((int) _r1.i);
    ((global::com.codename1.io.gzip.GZIPInputStream) _r2_o).@this((global::java.io.InputStream) _r3_o, (global::com.codename1.io.gzip.Inflater) _r0_o, (int) _r4.i, 0!=_r5.i);
    _r0.i = 1;
    ((global::com.codename1.io.gzip.GZIPInputStream) _r2_o)._fmyinflater = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream: void <init>(java.io.InputStream, int, boolean)]
}

public void @this(global::java.io.InputStream n1, global::com.codename1.io.gzip.Inflater n2, int n3, bool n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream: void <init>(java.io.InputStream, com.codename1.io.gzip.Inflater, int, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3.i = n3;
    _r4.i = n4 ? 1 : 0;
    ((global::com.codename1.io.gzip.InflaterInputStream) _r0_o).@this((global::java.io.InputStream) _r1_o, (global::com.codename1.io.gzip.Inflater) _r2_o, (int) _r3.i, 0!=_r4.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream: void <init>(java.io.InputStream, com.codename1.io.gzip.Inflater, int, boolean)]
}

public virtual long getModifiedtime(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream: long getModifiedtime()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r2_o)._finflater;
    _r0_o = ((global::com.codename1.io.gzip.Inflater) _r0_o)._fistate;
    _r0_o = ((global::com.codename1.io.gzip.Inflate) _r0_o).getGZIPHeader();
    _r0.l = ((global::com.codename1.io.gzip.GZIPHeader) _r0_o).getModifiedTime();
    return _r0.l;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream: long getModifiedtime()]
}

public virtual int getOS(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream: int getOS()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r1_o)._finflater;
    _r0_o = ((global::com.codename1.io.gzip.Inflater) _r0_o)._fistate;
    _r0_o = ((global::com.codename1.io.gzip.Inflate) _r0_o).getGZIPHeader();
    _r0.i = ((global::com.codename1.io.gzip.GZIPHeader) _r0_o).getOS();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream: int getOS()]
}

public virtual global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r1_o)._finflater;
    _r0_o = ((global::com.codename1.io.gzip.Inflater) _r0_o)._fistate;
    _r0_o = ((global::com.codename1.io.gzip.Inflate) _r0_o).getGZIPHeader();
    _r0_o = ((global::com.codename1.io.gzip.GZIPHeader) _r0_o).getName();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream: java.lang.String getName()]
}

public virtual global::System.Object getComment(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream: java.lang.String getComment()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r1_o)._finflater;
    _r0_o = ((global::com.codename1.io.gzip.Inflater) _r0_o)._fistate;
    _r0_o = ((global::com.codename1.io.gzip.Inflate) _r0_o).getGZIPHeader();
    _r0_o = ((global::com.codename1.io.gzip.GZIPHeader) _r0_o).getComment();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream: java.lang.String getComment()]
}

public virtual long getCRC(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream: long getCRC()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r2_o)._finflater;
    _r0_o = ((global::com.codename1.io.gzip.Inflater) _r0_o)._fistate;
    _r0.i = ((global::com.codename1.io.gzip.Inflate) _r0_o)._fmode;
    _r1.i = 12;
    if (_r0.i == _r1.i) goto label18;
    _r0_o = new global::com.codename1.io.gzip.GZIPException();
    // Value=checksum is not calculated yet.
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46))}));
    ((global::com.codename1.io.gzip.GZIPException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::com.codename1.io.gzip.GZIPException) _r0_o);
    label18:;
    _r0_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r2_o)._finflater;
    _r0_o = ((global::com.codename1.io.gzip.Inflater) _r0_o)._fistate;
    _r0_o = ((global::com.codename1.io.gzip.Inflate) _r0_o).getGZIPHeader();
    _r0.l = ((global::com.codename1.io.gzip.GZIPHeader) _r0_o).getCRC();
    return _r0.l;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream: long getCRC()]
}

public override void readHeader(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream: void readHeader()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r13_o = null;
    _r13_o = this;
    _r9.i = 10;
    _r12.i = 1;
    _r11.i = 0;
    // Value=no input
    _r10_o = new global::java.lang.String();
    ((global::java.lang.String)_r10_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116))}));
    // Value=
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r2_o = ((global::java.lang.String) _r8_o).getBytes();
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    ((global::com.codename1.io.gzip.Inflater) _r8_o).setOutput((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o, (int) _r11.i, (int) _r11.i);
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    ((global::com.codename1.io.gzip.Inflater) _r8_o).setInput((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o, (int) _r11.i, (int) _r11.i, 0!=_r11.i);
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r9.i]);
    _r6.i = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o).fill((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o);
    if (_r6.i == _r9.i) goto label53;
    if (_r6.i <= 0) goto label45;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    ((global::com.codename1.io.gzip.Inflater) _r8_o).setInput((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r11.i, (int) _r6.i, 0!=_r11.i);
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    ((global::com.codename1.io.gzip.Inflater) _r8_o)._fnext_1in_1index = _r11.i;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    ((global::com.codename1.io.gzip.Inflater) _r8_o)._favail_1in = _r6.i;
    label45:;
    _r8_o = new global::java.io.IOException();
    // Value=no input
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116))}));
    ((global::java.io.IOException) _r8_o).@this((global::java.lang.String) _r10_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r8_o);
    label53:;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    ((global::com.codename1.io.gzip.Inflater) _r8_o).setInput((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r11.i, (int) _r6.i, 0!=_r11.i);
    _r1_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r12.i]);
    label60:;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    _r8.i = ((global::com.codename1.io.gzip.Inflater) _r8_o)._favail_1in;
    if (_r8.i > 0) goto label87;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._fin;
    _r4.i = ((global::java.io.InputStream) _r8_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o);
    if (_r4.i > 0) goto label82;
    _r8_o = new global::java.io.IOException();
    // Value=no input
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116))}));
    ((global::java.io.IOException) _r8_o).@this((global::java.lang.String) _r10_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r8_o);
    label82:;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    ((global::com.codename1.io.gzip.Inflater) _r8_o).setInput((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o, (int) _r11.i, (int) _r12.i, 0!=_r12.i);
    label87:;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    _r3.i = ((global::com.codename1.io.gzip.Inflater) _r8_o).inflate((int) _r11.i);
    if (_r3.i == 0) goto label159;
    _r8.i = 2048;
    _r9_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    _r9_o = ((global::com.codename1.io.gzip.Inflater) _r9_o)._fnext_1in;
    _r9.i = ((global::org.xmlvm._nIArray) _r9_o).Length;
    _r5.i = _r8.i - _r9.i;
    if (_r5.i <= 0) goto label134;
    _r7_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r5.i]);
    _r6.i = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o).fill((global::org.xmlvm._nArrayAdapter<sbyte>) _r7_o);
    if (_r6.i <= 0) goto label134;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    _r9.i = ((global::com.codename1.io.gzip.Inflater) _r8_o)._favail_1in;
    _r10_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    _r10.i = ((global::com.codename1.io.gzip.Inflater) _r10_o)._fnext_1in_1index;
    _r9.i = _r9.i + _r10.i;
    ((global::com.codename1.io.gzip.Inflater) _r8_o)._favail_1in = _r9.i;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    ((global::com.codename1.io.gzip.Inflater) _r8_o)._fnext_1in_1index = _r11.i;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    ((global::com.codename1.io.gzip.Inflater) _r8_o).setInput((global::org.xmlvm._nArrayAdapter<sbyte>) _r7_o, (int) _r11.i, (int) _r6.i, 0!=_r12.i);
    label134:;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    _r9.i = ((global::com.codename1.io.gzip.Inflater) _r8_o)._favail_1in;
    _r10_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    _r10.i = ((global::com.codename1.io.gzip.Inflater) _r10_o)._fnext_1in_1index;
    _r9.i = _r9.i + _r10.i;
    ((global::com.codename1.io.gzip.Inflater) _r8_o)._favail_1in = _r9.i;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    ((global::com.codename1.io.gzip.Inflater) _r8_o)._fnext_1in_1index = _r11.i;
    _r8_o = new global::java.io.IOException();
    _r9_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    _r9_o = ((global::com.codename1.io.gzip.Inflater) _r9_o)._fmsg;
    ((global::java.io.IOException) _r8_o).@this((global::java.lang.String) _r9_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r8_o);
    label159:;
    _r8_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r13_o)._finflater;
    _r8_o = ((global::com.codename1.io.gzip.Inflater) _r8_o)._fistate;
    _r8.i = ((global::com.codename1.io.gzip.Inflate) _r8_o).inParsingHeader() ? 1 : 0;
    if (_r8.i != 0) goto label60;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream: void readHeader()]
}

private int fill(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream: int fill(byte[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6_o = n1;
    _r1.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r2.i = 0;
    label2:;
    _r0.i = -1;
    try {
    _r3_o = ((global::com.codename1.io.gzip.GZIPInputStream) _r5_o)._fin;
    _r4.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r4.i = _r4.i - _r2.i;
    _r0.i = ((global::java.io.InputStream) _r3_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r6_o, (int) _r2.i, (int) _r4.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    label11:;
    _r3.i = -1;
    if (_r0.i != _r3.i) goto label15;
    label14:;
    return _r2.i;
    label15:;
    _r2.i = _r2.i + _r0.i;
    if (_r2.i < _r1.i) goto label2;
    goto label14;
    label19:;
    _r3_o = _ex.getJavaException();
    _ex = null;
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream: int fill(byte[])]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.GZIPInputStream]
//XMLVM_END_WRAPPER[com.codename1.io.gzip.GZIPInputStream]

} // end of class: GZIPInputStream

} // end of namespace: com.codename1.io.gzip
