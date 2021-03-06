USE [trasen]
GO
/****** Object:  StoredProcedure [dbo].[sp_yp_ypgg]    Script Date: 07/13/2015 14:35:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_yp_ypgg]
(
	 @GGID INTEGER ,
	 @YPLX INTEGER,
	 @YPZLX INTEGER,
	 @GJBM VARCHAR(30),
	 @YPPM VARCHAR(100) ,
	 @YPSPM VARCHAR(100) ,
	 @YPSPMBZ VARCHAR(100),
	 @YPDW INTEGER ,
	 @YLFL INTEGER,
	 @YPJX INTEGER,
	 @HLXS DECIMAL(10,3) ,
	 @HLDW INTEGER ,
	 @BZSL INTEGER ,
	 @BZDW INTEGER,
	 @SYXL DECIMAL(10,3),
	 @YPGG VARCHAR(50),
	 @ZZBZ VARCHAR(200),
	 @BZ VARCHAR(200),
	 @BDELETE SMALLINT,
	 @SYFF INT,
	 @CFJB INT,
	 @DJYP BIT,
	 @MZYP BIT,
	 @PSYP BIT,
	 @JSYP BIT,
	 @GZYP BIT,
	 @CFYP BIT,
	 @WYYP BIT,
	 @LYFS INT,
	 @PYM VARCHAR(50),
	 @WBM VARCHAR(50),
	 @TLFL CHAR(2),
	 @hwjxbm varchar(10),
	 @ypywm varchar(100),
	 @XGR INT,
	 @rsyp bit,
	 @Newggid INTEGER output,
	 @ERR_CODE INTEGER output,
     @ERR_TEXT VARCHAR(100) output ,
	 @ZT VARCHAR(50) ,
	 @KSSDJ INT,--modefy by lwl 2011-10-12 抗生素等级
	 @DDD	DECIMAL(15,4),--modefy by lwl 2011-10-12 ddd值
	 @JBYW  BIT,--modefy by lwl 2011-10-12 国家基本药物
	 @gwyp bit, --高危药品
	 @JSYPFL SMALLINT,
	 @DPZYP bit, --单品种药品 add by ncq 2014-04-24
	 @DDDJL DECIMAL(15,4),
	 @DDDJLDW INT,
	 @JBYWLX INT, --基本药物类型 Add By Tany 2015-05-25 
	 @GWYPJB INT --高危药品级别 Add By pengy 2015-7-2
)
as
 declare @statitemcode varchar(10)

 SET @ERR_CODE=-1
 SET @NEWGGID=0

begin 
   IF @YPLX=0 
	begin
	      	set @err_text='药品类型必填'
		return
	end 
   
   IF @YPLX=0 
       begin
      	set @err_text='药品子类型必填'
	return
       end
   
   IF RTRIM(@YPSPM)='' 
	begin
    	  set @err_text='药品商品名必填'
	  return
	end 
   
   IF @YPJX=0 
   begin
      set @err_text='药品剂型必填'
  	return
   END  
   
   IF @YPDW=0 
	begin
     	 set @err_text='药品单位必填'
	  return
	end
   
   IF @hlxs<=0 
	begin
     	 set @err_text='药品剂量必填'
	  return
	end

   IF @hldw<=0 
	begin
     	 set @err_text='药品剂量单位必填'
	  return
	end
   
   IF @bzsl<=0 
	begin
     	 set @err_text='药品包装数量必填'
	  return
	end
   
   IF @bzdw<=0 
	begin
     	 set @err_text='药品剂包装单位必填'
	  return
	end



--DECLARE @TJDXM INT
--SET @TJDXM=(SELECT TJDXMDM FROM JC_TJDXMB WHERE CFLX=@YPLX AND XMLX=1)

--  if @yplx=1
--	SET @statitemcode='01'
--
--   if @yplx=2 
--  	  SET @statitemcode='02'
--
--  if @yplx=3
--   	  SET @statitemcode='03'
--
-- if @yplx>3  
--	   SET @statitemcode='01'

SET @statitemcode=(SELECT TJDXM FROM YP_YPLX WHERE ID=@YPLX )
IF @STATITEMCODE IS NULL
BEGIN
      set @err_text='该药品类型没有设置统计大项目'
	  return
END
   
   if @ggid=0 
	begin
	     	 set @err_text='插入药品规格信息'

		 declare @shh varchar(4)

	     update yp_yplx set HHJSQ=HHJSQ+1 WHERE ID=@YPLX
	     SET @shh=(select (left('0000',(4-len(rtrim(cast(hhjsq as char(4))))))+rtrim(cast(hhjsq  AS char(4)))) as yphh  from yp_yplx where id=@YPLX )
		 if len(@shh)<>4
		 begin
		      	set @err_text='货号生成时出错'
		    	return
		 end  		

		 insert into yp_ypggd(yplx,ypzlx,gjbm,yppm,ypspm,ypspmbz,ypdw,ylfl,ypjx,hlxs,hldw,bzsl,bzdw,syxl,ypgg,zzbz,
		 bz,bdelete,syff,cfjb,djyp,mzyp,psyp,jsyp,gzyp,cfyp,wyyp,lyfs,pym,wbm,djsj,statitem_code,tlfl,hwjxbm,hhjsq,ypywm,XGSJ,XGR,rsyp,ZT,DDD,KSSDJID,GJJBYW,GWYP,JSYPFL,DPZYP,DDDJL,DDDJLDW,JBYWLX,GWYPJB)
		 values (@yplx,@ypzlx,@gjbm,@yppm,@ypspm,@ypspmbz,@ypdw,@ylfl,@ypjx,@hlxs,@hldw,@bzsl,@bzdw,@syxl,@ypgg,@zzbz,
		 @bz,@bdelete,@syff,@cfjb,@djyp,@mzyp,@psyp,@jsyp,@gzyp,@cfyp,@wyyp,@lyfs,@pym,@wbm,getdate(),@statitemcode,@tlfl,@hwjxbm,@shh,@ypywm,getdate(),@XGR,@rsyp,@ZT,@DDD,@KSSDJ,@JBYW,@gwyp,@JSYPFL,@DPZYP,@DDDJL,@DDDJLDW,@JBYWLX,@GWYPJB)
		  if @@ROWCOUNT=0 
		      begin
		      	set @err_text='插入药品规格信息没有成功，影响到数据库0行'
			return
		      end 

		  set @Newggid=@@IDENTITY 

		  if @Newggid<=0 
		      begin
			  set @err_text='规格ID为零，数据库发生错误'
			  return
		      end
		  
		  set @err_text='插入药品别名信息'
		  insert into yp_ypbm(ggid,ypbm,pym,wbm,spmbz)values(@Newggid,@ypspm,@PYM,@WBM,1)
		  
		  set @err_text='已成功插入药品规格信息'
		  set @err_code=0
   	end


if @ggid>0 
  begin

	      	 set @err_text='更新药品规格信息'
	     	 update yp_ypggd set yplx=@yplx,ypzlx=@ypzlx,
			gjbm=@gjbm,yppm=@yppm,ypspm=@ypspm,
			ypspmbz=@ypspmbz,ypdw=@ypdw,ylfl=@ylfl,
			ypjx=@ypjx,hlxs=@hlxs,hldw=@hldw,bzsl=@bzsl,
			bzdw=@bzdw,syxl=@syxl,ypgg=@ypgg,
			zzbz=@zzbz,bz=@bz,bdelete=@bdelete,syff=@syff,
			cfjb=@cfjb,djyp=@djyp,mzyp=@mzyp,psyp=@psyp,
			jsyp=@jsyp,gzyp=@gzyp,cfyp=@cfyp,wyyp=@wyyp,
			lyfs=@lyfs,pym=@pym,wbm=@wbm,statitem_code=@statitemcode,tlfl=@tlfl,
			hwjxbm=@hwjxbm,ypywm=@ypywm,xgsj=getdate(),XGR=@XGR,rsyp=@rsyp,ZT=@ZT,
			DDD=@DDD,KSSDJID=@KSSDJ,GJJBYW=@JBYW,GWYP=@gwyp,JSYPFL=@JSYPFL,DPZYP=@DPZYP,
			DDDJL=@DDDJL,DDDJLDW=@DDDJLDW,JBYWLX=@JBYWLX,GWYPJB=@GWYPJB
			where ggid=@ggid
	
		
		  if @@ROWCOUNT=0 
			begin
			      	set @err_text='更新药品规格信息没有成功，影响到数据库0行'+Convert(NVARCHAR,@@ERROR)
				 return
			end 
	  
		  update yp_ypcjd set n_yplx=@yplx,n_ypzlx=@ypzlx,s_ypjx=dbo.fun_yp_ypjx(@ypjx),s_yppm=@yppm,s_ypspm=@ypspm,
		  s_ypgg=@ypgg,s_ypdw=dbo.fun_yp_ypdw(@ypdw) where ggid=@ggid

		  update yf_kcmx set zxdw=@ypdw where ggid=@ggid and dwbl=1
	  	  update yk_kcmx set zxdw=@ypdw where ggid=@ggid and dwbl=1
	  	  update yf_kcph set zxdw=@ypdw where ggid=@ggid and dwbl=1
		  update yk_kcmx set zxdw=@ypdw where ggid=@ggid and dwbl=1
		  update yP_ypcl set zxdw=@ypdw where ggid=@ggid and dwbl=1
	      update yp_ypcl set ypdw=@ypdw where ggid=@ggid
		  update yp_ypbm set ypbm=@ypspm,pym=@pym,wbm=@wbm where ggid=@ggid and spmbz=1

	  set @err_text='已成功更新药品规格信息  '+Convert(nvarchar,@ggid)+' aa'+Convert(NVARCHAR,@@ERROR)
  	  set @err_code=0
	  set @newggid=@ggid
	  
  end 
 end  

