// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.table {
public abstract class _iTableModel {

} // end of abstract class: _iTableModel

public interface TableModel {
 int getRowCount();

 int getColumnCount();

 global::System.Object getColumnName(int n1);

 bool isCellEditable(int n1, int n2);

 global::System.Object getValueAt(int n1, int n2);

 void setValueAt(int n1, int n2, global::java.lang.Object n3);

 void addDataChangeListener(global::com.codename1.ui.events.DataChangedListener n1);

 void removeDataChangeListener(global::com.codename1.ui.events.DataChangedListener n1);

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.table.TableModel]
//XMLVM_END_WRAPPER[com.codename1.ui.table.TableModel]

} // end of interface: TableModel

} // end of namespace: com.codename1.ui.table
