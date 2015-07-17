// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.io {
public class FileInputStream: global::java.io.InputStream,global::java.io.Closeable {
public global::java.io.FileDescriptor _ffd;

private global::java.nio.channels.FileChannel _fchannel;

public bool _finnerFD;

private global::org.apache.harmony.luni.platform.IFileSystem _ffileSystem;

private global::java.lang.Object _frepositioningLock;

public void @this(global::java.io.File n1){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: void <init>(java.io.File)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6_o = n1;
    _r1_o = null;
    _r4.i = 0;
    _r3.i = 1;
    ((global::java.io.InputStream) _r5_o).@this();
    _r0_o = global::org.apache.harmony.luni.platform.Platform.getFileSystem();
    ((global::java.io.FileInputStream) _r5_o)._ffileSystem = (global::org.apache.harmony.luni.platform.IFileSystem) _r0_o;
    _r0_o = new global::java.io.FileInputStream_2RepositioningLock();
    ((global::java.io.FileInputStream_2RepositioningLock) _r0_o).@this((global::java.io.FileInputStream_2RepositioningLock) _r1_o);
    ((global::java.io.FileInputStream) _r5_o)._frepositioningLock = (global::java.lang.Object) _r0_o;
    _r0_o = global::java.lang.System.getSecurityManager();
    if (_r0_o == null) goto label30;
    if (_r6_o != null) goto label44;
    label27:;
    ((global::java.lang.SecurityManager) _r0_o).checkRead((global::java.lang.String) _r1_o);
    label30:;
    if (_r6_o != null) goto label49;
    _r0_o = new global::java.lang.NullPointerException();
    // Value=luni.4D
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 52)), unchecked((char) unchecked((uint) 68))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.NullPointerException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label44:;
    _r1_o = ((global::java.io.File) _r6_o).getPath();
    goto label27;
    label49:;
    _r0_o = new global::java.io.FileDescriptor();
    ((global::java.io.FileDescriptor) _r0_o).@this();
    ((global::java.io.FileInputStream) _r5_o)._ffd = (global::java.io.FileDescriptor) _r0_o;
    _r0_o = ((global::java.io.FileInputStream) _r5_o)._ffd;
    ((global::java.io.FileDescriptor) _r0_o)._freadOnly = 0!=_r3.i;
    _r0_o = ((global::java.io.FileInputStream) _r5_o)._ffd;
    _r1_o = ((global::java.io.FileInputStream) _r5_o)._ffileSystem;
    _r2_o = ((global::java.io.File) _r6_o).properPath(0!=_r3.i);
    _r1.l = ((global::org.apache.harmony.luni.platform.IFileSystem) _r1_o).open((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o, (int) _r4.i);
    ((global::java.io.FileDescriptor) _r0_o)._fdescriptor = _r1.l;
    ((global::java.io.FileInputStream) _r5_o)._finnerFD = 0!=_r3.i;
    _r0_o = ((global::java.io.FileInputStream) _r5_o)._ffd;
    _r0.l = ((global::java.io.FileDescriptor) _r0_o)._fdescriptor;
    _r0_o = global::org.apache.harmony.nio.FileChannelFactory.getFileChannel((global::java.lang.Object) _r5_o, (long) _r0.l, (int) _r4.i);
    ((global::java.io.FileInputStream) _r5_o)._fchannel = (global::java.nio.channels.FileChannel) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.io.FileInputStream: void <init>(java.io.File)]
}

public void @this(global::java.io.FileDescriptor n1){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: void <init>(java.io.FileDescriptor)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 0;
    ((global::java.io.InputStream) _r3_o).@this();
    _r0_o = global::org.apache.harmony.luni.platform.Platform.getFileSystem();
    ((global::java.io.FileInputStream) _r3_o)._ffileSystem = (global::org.apache.harmony.luni.platform.IFileSystem) _r0_o;
    _r0_o = new global::java.io.FileInputStream_2RepositioningLock();
    _r1_o = null;
    ((global::java.io.FileInputStream_2RepositioningLock) _r0_o).@this((global::java.io.FileInputStream_2RepositioningLock) _r1_o);
    ((global::java.io.FileInputStream) _r3_o)._frepositioningLock = (global::java.lang.Object) _r0_o;
    if (_r4_o != null) goto label26;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label26:;
    _r0_o = global::java.lang.System.getSecurityManager();
    if (_r0_o == null) goto label35;
    ((global::java.lang.SecurityManager) _r0_o).checkRead((global::java.io.FileDescriptor) _r4_o);
    label35:;
    ((global::java.io.FileInputStream) _r3_o)._ffd = (global::java.io.FileDescriptor) _r4_o;
    ((global::java.io.FileInputStream) _r3_o)._finnerFD = 0!=_r2.i;
    _r0.l = ((global::java.io.FileDescriptor) _r4_o)._fdescriptor;
    _r0_o = global::org.apache.harmony.nio.FileChannelFactory.getFileChannel((global::java.lang.Object) _r3_o, (long) _r0.l, (int) _r2.i);
    ((global::java.io.FileInputStream) _r3_o)._fchannel = (global::java.nio.channels.FileChannel) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.io.FileInputStream: void <init>(java.io.FileDescriptor)]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    if (_r2_o != null) goto label7;
    _r0_o = null;
    label3:;
    ((global::java.io.FileInputStream) _r1_o).@this((global::java.io.File) _r0_o);
    return;
    label7:;
    _r0_o = new global::java.io.File();
    ((global::java.io.File) _r0_o).@this((global::java.lang.String) _r2_o);
    goto label3;
//XMLVM_END_WRAPPER[java.io.FileInputStream: void <init>(java.lang.String)]
}

public override int available(){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: int available()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    ((global::java.io.FileInputStream) _r4_o).openCheck();
    _r0_o = ((global::java.io.FileInputStream) _r4_o)._frepositioningLock;
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1_o = ((global::java.io.FileInputStream) _r4_o)._ffd;
    _r2_o = global::java.io.FileDescriptor._fin;
    if (_r1_o != _r2_o) goto label22;
    _r1_o = ((global::java.io.FileInputStream) _r4_o)._ffileSystem;
    _r1.l = ((global::org.apache.harmony.luni.platform.IFileSystem) _r1_o).ttyAvailable();
    _r1.i = (int) _r1.l;
    global::System.Threading.Monitor.Exit(_r0_o);
    _r0.i = _r1.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    label21:;
    try {
    return _r0.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    label22:;
    try {
    _r1_o = ((global::java.io.FileInputStream) _r4_o)._ffileSystem;
    _r2_o = ((global::java.io.FileInputStream) _r4_o)._ffd;
    _r2.l = ((global::java.io.FileDescriptor) _r2_o)._fdescriptor;
    _r1.l = ((global::org.apache.harmony.luni.platform.IFileSystem) _r1_o).available((long) _r2.l);
    _r1.i = (int) _r1.l;
    global::System.Threading.Monitor.Exit(_r0_o);
    _r0.i = _r1.i;
    goto label21;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    label36:;
    try {
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[java.io.FileInputStream: int available()]
}

public override void close(){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: void close()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r0_o = ((global::java.io.FileInputStream) _r4_o)._ffd;
    if (_r0_o != null) goto label5;
    label4:;
    return;
    label5:;
    _r0_o = ((global::java.io.FileInputStream) _r4_o)._fchannel;
    if (_r0_o == null) goto label26;
    _r0_o = ((global::java.io.FileInputStream) _r4_o)._fchannel;
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1_o = ((global::java.io.FileInputStream) _r4_o)._fchannel;
    _r1.i = ((global::java.nio.channels.FileChannel) _r1_o).isOpen() ? 1 : 0;
    if (_r1.i == 0) goto label25;
    _r1_o = ((global::java.io.FileInputStream) _r4_o)._fchannel;
    ((global::java.nio.channels.FileChannel) _r1_o).close();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    label25:;
    try {
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    label26:;
    global::System.Threading.Monitor.Enter(_r4_o);
    try {
    _r0_o = ((global::java.io.FileInputStream) _r4_o)._ffd;
    _r0.l = ((global::java.io.FileDescriptor) _r0_o)._fdescriptor;
    _r2.l = 0L;
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i < 0) goto label56;
    _r0.i = ((global::java.io.FileInputStream) _r4_o)._finnerFD ? 1 : 0;
    if (_r0.i == 0) goto label56;
    _r0_o = ((global::java.io.FileInputStream) _r4_o)._ffileSystem;
    _r1_o = ((global::java.io.FileInputStream) _r4_o)._ffd;
    _r1.l = ((global::java.io.FileDescriptor) _r1_o)._fdescriptor;
    ((global::org.apache.harmony.luni.platform.IFileSystem) _r0_o).close((long) _r1.l);
    _r0_o = ((global::java.io.FileInputStream) _r4_o)._ffd;
    _r1.l = -1L;
    ((global::java.io.FileDescriptor) _r0_o)._fdescriptor = _r1.l;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label58;
        }
        throw ex;
    } // end catch
    label56:;
    try {
    global::System.Threading.Monitor.Exit(_r4_o);
    goto label4;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label58;
        }
        throw ex;
    } // end catch
    label58:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r4_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label58;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    label61:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    try {
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[java.io.FileInputStream: void close()]
}

public override void @finally(){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: void finalize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.io.FileInputStream) _r0_o).close();
    return;
//XMLVM_END_WRAPPER[java.io.FileInputStream: void finalize()]
}

public virtual global::System.Object getChannel(){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: java.nio.channels.FileChannel getChannel()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.io.FileInputStream) _r1_o)._fchannel;
    return (global::java.nio.channels.FileChannel) _r0_o;
//XMLVM_END_WRAPPER[java.io.FileInputStream: java.nio.channels.FileChannel getChannel()]
}

public virtual global::System.Object getFD(){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: java.io.FileDescriptor getFD()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.io.FileInputStream) _r1_o)._ffd;
    return (global::java.io.FileDescriptor) _r0_o;
//XMLVM_END_WRAPPER[java.io.FileInputStream: java.io.FileDescriptor getFD()]
}

public override int read(){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: int read()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r1.i = 1;
    _r3.i = 0;
    _r2.i = -1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r1.i]);
    _r1.i = ((global::java.io.FileInputStream) _r4_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r3.i, (int) _r1.i);
    if (_r1.i != _r2.i) goto label13;
    _r0.i = _r2.i;
    label12:;
    return _r0.i;
    label13:;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r3.i];
    _r0.i = _r0.i & 255;
    goto label12;
//XMLVM_END_WRAPPER[java.io.FileInputStream: int read()]
}

public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: int read(byte[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r0.i = ((global::java.io.FileInputStream) _r2_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o, (int) _r0.i, (int) _r1.i);
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.FileInputStream: int read(byte[])]
}

public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: int read(byte[], int, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r8_o = n1;
    _r9.i = n2;
    _r10.i = n3;
    _r0.i = ((global::org.xmlvm._nIArray) _r8_o).Length;
    _r0.i = _r0.i - _r9.i;
    if (_r10.i > _r0.i) goto label8;
    if (_r10.i < 0) goto label8;
    if (_r9.i >= 0) goto label14;
    label8:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label14:;
    if (_r10.i != 0) goto label18;
    _r0.i = 0;
    label17:;
    return _r0.i;
    label18:;
    ((global::java.io.FileInputStream) _r7_o).openCheck();
    _r6_o = ((global::java.io.FileInputStream) _r7_o)._frepositioningLock;
    global::System.Threading.Monitor.Enter(_r6_o);
    try {
    _r0_o = ((global::java.io.FileInputStream) _r7_o)._ffd;
    _r1_o = global::java.io.FileDescriptor._fin;
    if (_r0_o != _r1_o) goto label42;
    _r0_o = ((global::java.io.FileInputStream) _r7_o)._ffileSystem;
    _r0.l = ((global::org.apache.harmony.luni.platform.IFileSystem) _r0_o).ttyRead((global::org.xmlvm._nArrayAdapter<sbyte>) _r8_o, (int) _r9.i, (int) _r10.i);
    _r0.i = (int) _r0.l;
    global::System.Threading.Monitor.Exit(_r6_o);
    goto label17;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label39;
        }
        throw ex;
    } // end catch
    label39:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r6_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label39;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    label42:;
    try {
    _r0_o = ((global::java.io.FileInputStream) _r7_o)._ffileSystem;
    _r1_o = ((global::java.io.FileInputStream) _r7_o)._ffd;
    _r1.l = ((global::java.io.FileDescriptor) _r1_o)._fdescriptor;
    _r3_o = _r8_o;
    _r4.i = _r9.i;
    _r5.i = _r10.i;
    _r0.l = ((global::org.apache.harmony.luni.platform.IFileSystem) _r0_o).read((long) _r1.l, (global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o, (int) _r4.i, (int) _r5.i);
    _r0.i = (int) _r0.l;
    global::System.Threading.Monitor.Exit(_r6_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label39;
        }
        throw ex;
    } // end catch
    goto label17;
//XMLVM_END_WRAPPER[java.io.FileInputStream: int read(byte[], int, int)]
}

public override long skip(long n1){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: long skip(long)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r12_o = this;
    _r13.l = n1;
    _r10.l = 0L;
    ((global::java.io.FileInputStream) _r12_o).openCheck();
    _r0.i = _r13.l > _r10.l ? 1 : (_r13.l == _r10.l ? 0 : -1);
    if (_r0.i != 0) goto label11;
    _r0.l = _r10.l;
    label10:;
    return _r0.l;
    label11:;
    _r0.i = _r13.l > _r10.l ? 1 : (_r13.l == _r10.l ? 0 : -1);
    if (_r0.i >= 0) goto label27;
    _r0_o = new global::java.io.IOException();
    // Value=luni.AC
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 67))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.io.IOException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    label27:;
    _r0_o = ((global::java.io.FileInputStream) _r12_o)._ffd;
    _r1_o = global::java.io.FileDescriptor._fin;
    if (_r0_o != _r1_o) goto label74;
    _r0.l = 8192L;
    _r0.i = _r13.l > _r0.l ? 1 : (_r13.l == _r0.l ? 0 : -1);
    if (_r0.i >= 0) goto label52;
    _r0.i = (int) _r13.l;
    label40:;
    _r1_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r0.i]);
    _r2.l = (long) _r0.i;
    _r2.l = _r13.l / _r2.l;
    _r4.l = _r10.l;
    label46:;
    _r6.i = _r2.l > _r10.l ? 1 : (_r2.l == _r10.l ? 0 : -1);
    if (_r6.i >= 0) goto label55;
    _r0.l = _r4.l;
    goto label10;
    label52:;
    _r0.i = 8192;
    goto label40;
    label55:;
    _r6_o = ((global::java.io.FileInputStream) _r12_o)._ffileSystem;
    _r7.i = 0;
    _r6.l = ((global::org.apache.harmony.luni.platform.IFileSystem) _r6_o).ttyRead((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o, (int) _r7.i, (int) _r0.i);
    _r4.l = _r4.l + _r6.l;
    _r8.l = (long) _r0.i;
    _r6.i = _r6.l > _r8.l ? 1 : (_r6.l == _r8.l ? 0 : -1);
    if (_r6.i >= 0) goto label70;
    _r0.l = _r4.l;
    goto label10;
    label70:;
    _r6.l = 1L;
    _r2.l = _r2.l - _r6.l;
    goto label46;
    label74:;
    _r6_o = ((global::java.io.FileInputStream) _r12_o)._frepositioningLock;
    global::System.Threading.Monitor.Enter(_r6_o);
    try {
    _r0_o = ((global::java.io.FileInputStream) _r12_o)._ffileSystem;
    _r1_o = ((global::java.io.FileInputStream) _r12_o)._ffd;
    _r1.l = ((global::java.io.FileDescriptor) _r1_o)._fdescriptor;
    _r3.l = 0L;
    _r5.i = 2;
    _r7.l = ((global::org.apache.harmony.luni.platform.IFileSystem) _r0_o).seek((long) _r1.l, (long) _r3.l, (int) _r5.i);
    _r0_o = ((global::java.io.FileInputStream) _r12_o)._ffileSystem;
    _r1_o = ((global::java.io.FileInputStream) _r12_o)._ffd;
    _r1.l = ((global::java.io.FileDescriptor) _r1_o)._fdescriptor;
    _r3.l = _r7.l + _r13.l;
    _r5.i = 1;
    _r0.l = ((global::org.apache.harmony.luni.platform.IFileSystem) _r0_o).seek((long) _r1.l, (long) _r3.l, (int) _r5.i);
    _r0.l = _r0.l - _r7.l;
    global::System.Threading.Monitor.Exit(_r6_o);
    goto label10;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label106;
        }
        throw ex;
    } // end catch
    label106:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r6_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label106;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
//XMLVM_END_WRAPPER[java.io.FileInputStream: long skip(long)]
}

private void openCheck(){
//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream: void openCheck()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    global::System.Threading.Monitor.Enter(_r4_o);
    try {
    _r0_o = ((global::java.io.FileInputStream) _r4_o)._ffd;
    _r0.l = ((global::java.io.FileDescriptor) _r0_o)._fdescriptor;
    _r2.l = 0L;
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i >= 0) goto label20;
    _r0_o = new global::java.io.IOException();
    ((global::java.io.IOException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label17;
        }
        throw ex;
    } // end catch
    label17:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r4_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
    label20:;
    global::System.Threading.Monitor.Exit(_r4_o);
    return;
//XMLVM_END_WRAPPER[java.io.FileInputStream: void openCheck()]
}

//XMLVM_BEGIN_WRAPPER[java.io.FileInputStream]
//XMLVM_END_WRAPPER[java.io.FileInputStream]

} // end of class: FileInputStream

} // end of namespace: java.io
