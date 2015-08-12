// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.tar {
public class TarInputStream: global::com.codename1.io.BufferedInputStream {

private global::com.codename1.io.tar.TarEntry _fcurrentEntry;

private long _fcurrentFileSize;

private long _fbytesRead;

private bool _fdefaultSkip;

public void @this(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: void <init>(java.io.InputStream)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r1.l = 0L;
    ((global::com.codename1.io.BufferedInputStream) _r3_o).@this((global::java.io.InputStream) _r4_o);
    _r0.i = 0;
    ((global::com.codename1.io.tar.TarInputStream) _r3_o)._fdefaultSkip = 0!=_r0.i;
    ((global::com.codename1.io.tar.TarInputStream) _r3_o)._fcurrentFileSize = _r1.l;
    ((global::com.codename1.io.tar.TarInputStream) _r3_o)._fbytesRead = _r1.l;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: void <init>(java.io.InputStream)]
}

public override bool markSupported(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: boolean markSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: boolean markSupported()]
}

public override void mark(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: void mark(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    global::System.Threading.Monitor.Enter(_r0_o);
    global::System.Threading.Monitor.Exit(_r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: void mark(int)]
}

public override void reset(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: void reset()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    global::System.Threading.Monitor.Enter(_r2_o);
    try {
    _r0_o = new global::java.io.IOException();
    // Value=mark/reset not supported
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::java.io.IOException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label9;
        }
        throw ex;
    } // end catch
    label9:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: void reset()]
}

public override int read(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: int read()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r2.i = 1;
    _r3.i = 0;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r2.i]);
    _r1.i = ((global::com.codename1.io.tar.TarInputStream) _r4_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r3.i, (int) _r2.i);
    _r2.i = -1;
    if (_r1.i == _r2.i) goto label14;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r3.i];
    label13:;
    return _r2.i;
    label14:;
    _r2.i = _r1.i;
    goto label13;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: int read()]
}

public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: int read(byte[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    _r6_o = this;
    _r7_o = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r5.i = -1;
    _r1_o = ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fcurrentEntry;
    if (_r1_o == null) goto label43;
    _r1.l = ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fcurrentFileSize;
    _r3_o = ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fcurrentEntry;
    _r3.l = ((global::com.codename1.io.tar.TarEntry) _r3_o).getSize();
    _r1.i = _r1.l > _r3.l ? 1 : (_r1.l == _r3.l ? 0 : -1);
    if (_r1.i != 0) goto label19;
    _r1.i = _r5.i;
    label18:;
    return _r1.i;
    label19:;
    _r1_o = ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fcurrentEntry;
    _r1.l = ((global::com.codename1.io.tar.TarEntry) _r1_o).getSize();
    _r3.l = ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fcurrentFileSize;
    _r1.l = _r1.l - _r3.l;
    _r3.l = (long) _r9.i;
    _r1.i = _r1.l > _r3.l ? 1 : (_r1.l == _r3.l ? 0 : -1);
    if (_r1.i >= 0) goto label43;
    _r1_o = ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fcurrentEntry;
    _r1.l = ((global::com.codename1.io.tar.TarEntry) _r1_o).getSize();
    _r3.l = ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fcurrentFileSize;
    _r1.l = _r1.l - _r3.l;
    _r9.i = (int) _r1.l;
    label43:;
    _r0.i = base.read((global::org.xmlvm._nArrayAdapter<sbyte>) _r7_o, (int) _r8.i, (int) _r9.i);
    if (_r0.i == _r5.i) goto label65;
    _r1_o = ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fcurrentEntry;
    if (_r1_o == null) goto label59;
    _r1.l = ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fcurrentFileSize;
    _r3.l = (long) _r0.i;
    _r1.l = _r1.l + _r3.l;
    ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fcurrentFileSize = _r1.l;
    label59:;
    _r1.l = ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fbytesRead;
    _r3.l = (long) _r0.i;
    _r1.l = _r1.l + _r3.l;
    ((global::com.codename1.io.tar.TarInputStream) _r6_o)._fbytesRead = _r1.l;
    label65:;
    _r1.i = _r0.i;
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: int read(byte[], int, int)]
}

public virtual global::System.Object getNextEntry(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: com.codename1.io.tar.TarEntry getNextEntry()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r13_o = null;
    _r13_o = this;
    _r11.i = 0;
    _r10.i = 512;
    ((global::com.codename1.io.tar.TarInputStream) _r13_o).closeCurrentEntry();
    _r3_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r10.i]);
    _r7_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r10.i]);
    _r8.i = 0;
    label11:;
    if (_r8.i >= _r10.i) goto label21;
    _r9.i = _r10.i - _r8.i;
    _r6.i = ((global::com.codename1.io.tar.TarInputStream) _r13_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r7_o, (int) _r11.i, (int) _r9.i);
    if (_r6.i >= 0) goto label51;
    label21:;
    _r2.i = 1;
    _r0_o = _r3_o;
    _r5.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r4.i = 0;
    label25:;
    if (_r4.i >= _r5.i) goto label32;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r4.i];
    if (_r1.i == 0) goto label56;
    _r2.i = 0;
    label32:;
    if (_r2.i != 0) goto label48;
    _r9.l = ((global::com.codename1.io.tar.TarInputStream) _r13_o)._fbytesRead;
    _r11.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r11.l = (long) _r11.i;
    _r9.l = _r9.l + _r11.l;
    ((global::com.codename1.io.tar.TarInputStream) _r13_o)._fbytesRead = _r9.l;
    _r9_o = new global::com.codename1.io.tar.TarEntry();
    ((global::com.codename1.io.tar.TarEntry) _r9_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o);
    ((global::com.codename1.io.tar.TarInputStream) _r13_o)._fcurrentEntry = (global::com.codename1.io.tar.TarEntry) _r9_o;
    label48:;
    _r9_o = ((global::com.codename1.io.tar.TarInputStream) _r13_o)._fcurrentEntry;
    return (global::com.codename1.io.tar.TarEntry) _r9_o;
    label51:;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r7_o, (int) _r11.i, (global::java.lang.Object) _r3_o, (int) _r8.i, (int) _r6.i);
    _r8.i = _r8.i + _r6.i;
    goto label11;
    label56:;
    _r4.i = _r4.i + 1;
    goto label25;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: com.codename1.io.tar.TarEntry getNextEntry()]
}

public virtual void closeCurrentEntry(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: void closeCurrentEntry()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r10_o = null;
    _r10_o = this;
    _r8.l = 0L;
    _r4_o = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentEntry;
    if (_r4_o == null) goto label82;
    _r4_o = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentEntry;
    _r4.l = ((global::com.codename1.io.tar.TarEntry) _r4_o).getSize();
    _r6.l = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentFileSize;
    _r4.i = _r4.l > _r6.l ? 1 : (_r4.l == _r6.l ? 0 : -1);
    if (_r4.i <= 0) goto label74;
    _r0.l = 0L;
    label20:;
    _r4_o = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentEntry;
    _r4.l = ((global::com.codename1.io.tar.TarEntry) _r4_o).getSize();
    _r6.l = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentFileSize;
    _r4.l = _r4.l - _r6.l;
    _r4.i = _r0.l > _r4.l ? 1 : (_r0.l == _r4.l ? 0 : -1);
    if (_r4.i >= 0) goto label74;
    _r4_o = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentEntry;
    _r4.l = ((global::com.codename1.io.tar.TarEntry) _r4_o).getSize();
    _r6.l = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentFileSize;
    _r4.l = _r4.l - _r6.l;
    _r4.l = _r4.l - _r0.l;
    _r2.l = ((global::com.codename1.io.tar.TarInputStream) _r10_o).skip((long) _r4.l);
    _r4.i = _r2.l > _r8.l ? 1 : (_r2.l == _r8.l ? 0 : -1);
    if (_r4.i != 0) goto label72;
    _r4_o = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentEntry;
    _r4.l = ((global::com.codename1.io.tar.TarEntry) _r4_o).getSize();
    _r6.l = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentFileSize;
    _r4.l = _r4.l - _r6.l;
    _r4.i = _r4.l > _r8.l ? 1 : (_r4.l == _r8.l ? 0 : -1);
    if (_r4.i <= 0) goto label72;
    _r4_o = new global::java.io.IOException();
    // Value=Possible tar file corruption
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::java.io.IOException) _r4_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r4_o);
    label72:;
    _r0.l = _r0.l + _r2.l;
    goto label20;
    label74:;
    _r4_o = null;
    ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentEntry = (global::com.codename1.io.tar.TarEntry) _r4_o;
    ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fcurrentFileSize = _r8.l;
    ((global::com.codename1.io.tar.TarInputStream) _r10_o).skipPad();
    label82:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: void closeCurrentEntry()]
}

public virtual void skipPad(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: void skipPad()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    _r10_o = this;
    _r9.i = 512;
    _r5.l = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fbytesRead;
    _r7.l = 0L;
    _r5.i = _r5.l > _r7.l ? 1 : (_r5.l == _r7.l ? 0 : -1);
    if (_r5.i <= 0) goto label37;
    _r5.l = ((global::com.codename1.io.tar.TarInputStream) _r10_o)._fbytesRead;
    _r7.l = 512L;
    _r5.l = _r5.l % _r7.l;
    _r2.i = (int) _r5.l;
    if (_r2.i <= 0) goto label37;
    _r0.l = 0L;
    label20:;
    _r5.i = _r9.i - _r2.i;
    _r5.l = (long) _r5.i;
    _r5.i = _r0.l > _r5.l ? 1 : (_r0.l == _r5.l ? 0 : -1);
    if (_r5.i >= 0) goto label37;
    _r5.i = _r9.i - _r2.i;
    _r5.l = (long) _r5.i;
    _r5.l = _r5.l - _r0.l;
    _r3.l = ((global::com.codename1.io.tar.TarInputStream) _r10_o).skip((long) _r5.l);
    _r0.l = _r0.l + _r3.l;
    goto label20;
    label37:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: void skipPad()]
}

public override long skip(long n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: long skip(long)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    _r11_o = this;
    _r12.l = n1;
    _r9.l = 2048L;
    _r7.l = 0L;
    _r4.i = ((global::com.codename1.io.tar.TarInputStream) _r11_o)._fdefaultSkip ? 1 : 0;
    if (_r4.i == 0) goto label13;
    _r4.l = base.skip((long) _r12.l);
    label12:;
    return _r4.l;
    label13:;
    _r4.i = _r12.l > _r7.l ? 1 : (_r12.l == _r7.l ? 0 : -1);
    if (_r4.i > 0) goto label19;
    _r4.l = _r7.l;
    goto label12;
    label19:;
    _r0.l = _r12.l;
    _r4.i = 2048;
    _r3_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r4.i]);
    label24:;
    _r4.i = _r0.l > _r7.l ? 1 : (_r0.l == _r7.l ? 0 : -1);
    if (_r4.i <= 0) goto label41;
    _r4.i = 0;
    _r5.i = _r0.l > _r9.l ? 1 : (_r0.l == _r9.l ? 0 : -1);
    if (_r5.i >= 0) goto label44;
    _r5.l = _r0.l;
    label34:;
    _r5.i = (int) _r5.l;
    _r2.i = ((global::com.codename1.io.tar.TarInputStream) _r11_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o, (int) _r4.i, (int) _r5.i);
    if (_r2.i >= 0) goto label46;
    label41:;
    _r4.l = _r12.l - _r0.l;
    goto label12;
    label44:;
    _r5.l = _r9.l;
    goto label34;
    label46:;
    _r4.l = (long) _r2.i;
    _r0.l = _r0.l - _r4.l;
    goto label24;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: long skip(long)]
}

public virtual bool isDefaultSkip(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: boolean isDefaultSkip()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.io.tar.TarInputStream) _r1_o)._fdefaultSkip ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: boolean isDefaultSkip()]
}

public virtual void setDefaultSkip(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream: void setDefaultSkip(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.io.tar.TarInputStream) _r0_o)._fdefaultSkip = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream: void setDefaultSkip(boolean)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.tar.TarInputStream]
//XMLVM_END_WRAPPER[com.codename1.io.tar.TarInputStream]

} // end of class: TarInputStream

} // end of namespace: com.codename1.io.tar
