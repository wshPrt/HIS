USE [Trasen_0329]
GO
/****** Object:  Trigger [dbo].[TR_MZ_YYGHLB_INSERTFOREVENTLOG]    Script Date: 2017/8/31 16:41:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO



--Add By Tany 2015-09-29 新增预约信息
ALTER TRIGGER [dbo].[TR_MZ_YYGHLB_INSERTFOREVENTLOG]
	ON [dbo].[MZ_YYGHLB] 
	AFTER INSERT
AS   
SET NOCOUNT ON

	insert into EVENTLOG(EVENT,CATEGORY,BIZID) 
	select 'GetYyMsgInfo','MZ_YYGHLB',yyid 
	from inserted
	-- Add By Mr.Chan 2017-08-30 更新限制发送预约短信的渠道列表
	where PTID not in ('1','10','11','17','18','20','30','50','60','61','63','80','90') --限制发送预约短信的渠道 2015-12-21
    --where PTID not in ('10','11','20','90','1','17','13','30','50','60')


