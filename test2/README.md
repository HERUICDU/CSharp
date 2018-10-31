  # 第二次作业
- 何蕊

赵老师，您好！之前由于电脑配置不行，一直装不起软件，对此非常抱歉。但是我一直没有停止学习老师在课堂上教的知识，
积极请教班上同学，认真完成老师布置的作业，现在已经成功安装好了软件，对从IDEA上传文件这些操作都学会了，对于XML格
式的学习还是浅尝截止，作业可能还有欠缺，对此我一定更深入学习，掌握核心思想。

  ## XML格式分析说明书
  
  把Word 文档另存为XML文档保存
  
  XML文档中第一行是声明。本文档中XML的版本1.0，所使用编码为UTF-8。XML是可扩展标记语言，文档中有很多尖括符，由一个小于号（<）和一个大于号（>）之间的文本组成一个标签，
  例如<标记>。一个节点由两部分组成：开始标签<>和结束标签</>。尖括符中间是节点的值。
  
  ### XML的声明和名称空间的指明：
  <?xml version="1.0" encoding="UTF-8" standalone="yes"?>
  <pkg:package xmlns:pkg="http://schemas.microsoft.com/office/2006/xmlPackage">
  
  #### 文档内容
 
  <<w:body>>文档内容的开始标签；<</w:body>>文档内容的结束标签
  
  #### 节点类型
 
- 基本类型
     
     
     <<w:p>> 表示一个段落
     <<w:r>> 表示一个样式串，指明它包括的文本的显示样式
     <<w:t>>表示真正的文本内容
     <w:b w:val=”on”> 表示该格式串种的文本为粗体
     <<w:pPr>> </w:pPr> 段落的设置参数是在这个标签中
     </<w:jc w:val="center">>文档的格式是居中
     < w:jc w:val="right"/> 右对齐
     将段属性包含在<<w:pPr>>  </w:pPr>中
     将文本格式包含在<<w:rPr>>  </w:rPr>中

  - 页的宽，高，和页的各边距。各项的值均是英寸乘1440得出：
   
     <w:bodyr>...
     <w:sectPr>
     <w:pgSz w:w="11906" w:h="16838"/>
     <w:pgMar w:top="1440" w:right="1800" w:bottom="1440" w:left="1800" w:header="851" w:footer="992"
     < /w:sectPr>
     </w:body>

  - 页的页眉页脚：
  
    w:sectPr wsp:rsidR="002C452C">
    <w:hdr w:type="odd" >
    <w:p>
    <w:pPr>
    <w:pStyle w:val="Header"/>
    </w:pPr>
    <w:r>
    <w:t>My Header</w:t>
    </w:r>
    </w:p>
    </w:hdr>
    <w:ftr w:type="odd">
    <w:p>
    <w:pPr>
    <w:pStyle w:val="Footer"/>
    </w:pPr>
    <w:r>
    <w:t>My Footer</w:t>
    </w:r>
    </w:p>
    </w:ftr>
    </w:sectPr>
    </w:body>
  
 - 文档设置
 
     
     </w:body>
     <w:docPr>
     <w:view w:val="print"/><w:zoom w:percent="100"/>
     < /w:docPr>
     </w:wordDocument>
     docPr，就是document property的意思
     表示文档的视图是“print”，视图比例100%

