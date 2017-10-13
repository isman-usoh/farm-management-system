using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainProject.Util
{
    public class DialogUtil
    {
        public static DialogResult SaveSuccess()
        {
            MessageBox.Show("บันทึกข้อมูลเสร็จสมบูรณ์", "เสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return DialogResult.Yes;
        }
        public static DialogResult AddSuccess()
        {
            MessageBox.Show("เพิ่มข้อมูลเสร็จสมบูรณ์", "เสร็จสมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return DialogResult.Yes;
        }
        public static DialogResult AddError()
        {
            MessageBox.Show("ไม่สามารถเพิ่มข้อมูล", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return DialogResult.No;
        }
        public static DialogResult SaveError()
        {
            MessageBox.Show("ไม่สามารถบันทึกข้อมูล", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return DialogResult.No;
        }
        public static DialogResult SaveErrorAnswer()
        {
            return MessageBox.Show("ไม่สามารถบันทึกข้อมูล คุณต้องการกลับไปแก้ไขหรือใหม่", "ข้อผิดผลาด", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult NoRecord()
        {
            return MessageBox.Show("ไม่พบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult NotInserRecord(String value)
        {
            return MessageBox.Show(String.Format("ผู้ใช้ยังไม่ได้เพิ่มข้อมูล{0} กรุณาลองใหม่อีกครั้ง", value), "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult DateIncomplete()
        {
            return MessageBox.Show("ผู้ใช้ป้อนข้อมูลไม่ครบ กรุณาตรวจและป้อนข้อมูลใหม่อีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult Incomplete()
        {
            return MessageBox.Show("การทำงานไม่สมบูรณ์ กรุณาลองใหม่อีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
