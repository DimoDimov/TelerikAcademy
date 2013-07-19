<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  
  <xsl:template match="/">
    <html>
      <body>
        <h1>My Student</h1>
        <table bgcolor="#E0E0E0" cellspacing="1">
          <tr bgcolor="#EEEEEE">
            <td>
              <b>Name</b>
            </td>
            <td>
              <b>Sex</b>
            </td>
            <td>
              <b>Phone</b>
            </td>
            <td>
              <b>E-mail</b>
            </td>
            <td>
              <b>Course</b>
            </td>
            <td>
              <b>Specialty</b>
            </td>
            <td>
              <b>Faculty-Number</b>
            </td>
            <td>
              <b>Exam-Name</b>
            </td>
            <td>
              <b>Exam-Tutor</b>
            </td>
            <td>
              <b>Exam-Score</b>
            </td>
            <td>
              <b>Exam-Date</b>
            </td>
            <td>
              <b>Teacher</b>
            </td>
          </tr>
          <xsl:for-each select="students/student" >
            <tr bgcolor="blue">
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="sex"/>
              </td>
              <td>
                <xsl:value-of select="birthdate"/>
              </td>
              <td>
                <xsl:value-of select="phone"/>
              </td>
              <td>
                <xsl:value-of select="email"/>
              </td>
              <td>
                <xsl:value-of select="course"/>
              </td>
              <td>
                <xsl:value-of select="specialty"/>
              </td>
              <td>
                <xsl:value-of select="faculty-number"/>
              </td>
              <td>
                <xsl:value-of select="exams/exam/name"/>
              </td>
              <td>
                <xsl:value-of select="exams/exam/tutor"/>
              </td>
              <td>
                <xsl:value-of select="exams/exam/score"/>
              </td>
              <td>
                <xsl:value-of select="enrollment/exam/date"/>
              </td>
              <td>
                <xsl:value-of select="enrollment/exam/exam-score"/>
              </td>
              <td>
                <xsl:value-of select="enrollment/exam/teacher"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
    </xsl:template>
</xsl:stylesheet>
