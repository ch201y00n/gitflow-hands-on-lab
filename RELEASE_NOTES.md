# Release Notes

## Release 2025-11-11 🚀

### 📅 Release Date
2025년 11월 11일

### 🎯 주요 변경사항

#### ✨ 새로운 기능
- **도시 열거 기능 추가** (`Test.cs`)
  - 20개 한국 주요 도시 목록 제공
  - 도시 열거, 랜덤 선택, 유효성 검사 메서드 구현
  - 날씨 API 테스트를 위한 기반 클래스 제공

#### 🐛 버그 수정
- **GFHOL-5**: 프로그램 버그 수정
  - 도시 데이터 처리 관련 이슈 해결
  - 테스트 인프라 개선

#### 🔧 개선사항
- 네임스페이스 선언 리팩토링
- 코드 구조 개선 및 정리

### 📋 포함된 커밋
- `a020aaa` - GFHOL-5 #close 프로그램 버그
- `316e1f3` - refactor: add namespace declarations to MainData, WeatherData, WeatherInfo, WeatherResponse, and WindInfo classes

### 🔗 관련 이슈
- [GFHOL-5](https://coontec.atlassian.net/browse/GFHOL-5): 프로그램 버그 ✅ 완료

### 📝 기술적 세부사항

#### 새로 추가된 파일
- **Test.cs**: 도시 열거 및 테스트 유틸리티 클래스
  - `Cities`: 20개 한국 주요 도시 정적 리스트
  - `EnumerateCities()`: 모든 도시를 번호와 함께 콘솔 출력
  - `GetRandomCity()`: 테스트용 랜덤 도시 반환
  - `IsValidCity()`: 도시 이름 유효성 검사

#### 도시 목록
Seoul, Busan, Incheon, Daegu, Daejeon, Gwangju, Ulsan, Suwon, Goyang, Seongnam, Bucheon, Ansan, Cheongju, Jeonju, Anyang, Cheonan, Pohang, Changwon, Gimhae, Jeju

### 🚀 배포 정보
- **Git 태그**: `2025-11-11`
- **브랜치**: `release/2025-11-11`
- **Pull Request**: [#3](https://github.com/ch201y00n/gitflow-hands-on-lab/pull/3)

### 🔄 업그레이드 가이드
이번 릴리스는 새로운 기능 추가이므로 기존 코드와 호환됩니다.

### 📞 문의사항
버그 신고나 기능 요청은 [Jira](https://coontec.atlassian.net)를 통해 제출해 주세요.

---
**Previous Releases**: [2025-11-10](./RELEASE_NOTES.md#release-2025-11-10) | [2025-11-06](./RELEASE_NOTES.md#release-2025-11-06)