
/****** RUN THIS FROM THE ROOT DATABASE (AWMain)  ******/

SELECT [CurrencyRateID]
      ,[CurrencyRateDate]
      ,[FromCurrencyCode]
      ,[ToCurrencyCode]
      ,[AverageRate]
      ,[EndOfDayRate]
FROM 
	[Sales].[CurrencyRate]
