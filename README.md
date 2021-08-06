# MovieWeb

**Problem**: Front ve back bağlantısı yaparken cross platform policy hatası nedeniyle backend isteği bloke ediyordu. 

**Çözüm**: Backend startup içinde configure kısmında app.UseCors() dedikten sonra hangi isteklere izin verileceği configureServiceste services.AddCors() içersine AllowAnyOrigin diyerek yani istek gelecek her yeri şimdilik kabul etmiş oldum.

**Problem** : Backend'ten dönen text değerini angularda yakalayamamak.

**Çözüm**: Http Requestler default olarak json formatındadır. Ben backend'ten text  yolladığım için json'a parse etmeye çalışırken hata aldım. http nin default formatı olan json'u manuel olarak text yaptıktan sonra problem çözüldü.

