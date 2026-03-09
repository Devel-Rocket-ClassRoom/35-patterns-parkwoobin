# 게임 아이템 시스템

RPG 게임의 아이템 시스템을 패턴 매칭으로 구현하세요.

**요구사항**

1. 아이템 클래스 계층 구조:
   - `Item` 기본 클래스: `Name`, `Rarity` (Common, Uncommon, Rare, Epic, Legendary)
   - `Weapon`: `Damage`, `WeaponType` (Sword, Bow, Staff)
   - `Armor`: `Defense`, `ArmorType` (Helmet, Chest, Boots)
   - `Consumable`: `Effect`, `Duration`

2. `GetItemValue` 메서드: 아이템의 가치(골드)를 계산
   - 기본 가치는 Rarity에 따라: Common=10, Uncommon=50, Rare=200, Epic=1000, Legendary=5000
   - Weapon: 기본 가치 + (Damage x 10)
   - Armor: 기본 가치 + (Defense x 15)
   - Consumable: 기본 가치 + (Duration x 5)

3. `CanEquip` 메서드: 캐릭터 레벨과 클래스에 따른 장착 가능 여부
   - 튜플 패턴 사용: (아이템 타입, 캐릭터 클래스, 레벨)
   - Sword: Warrior만 장착, 레벨 10 이상
   - Bow: Archer만 장착, 레벨 10 이상
   - Staff: Mage만 장착, 레벨 10 이상
   - Armor: 모든 클래스, 레벨 5 이상
   - Consumable: 모든 클래스, 레벨 제한 없음

4. `GetItemDescription` 메서드: 아이템 정보를 문자열로 반환
   - 속성 패턴과 when 절 활용
   - Legendary 무기이면서 Damage가 100 이상: "전설의 {WeaponType}!"
   - Epic 이상 방어구이면서 Defense가 50 이상: "강력한 방어구"

**구현 조건**

- 모든 메서드에서 패턴 매칭 활용
- 열거형(enum)으로 Rarity, WeaponType, ArmorType, CharacterClass 정의

## 예상 실행 결과

```
=== 게임 아이템 시스템 ===

[아이템 목록]
화염검 (Legendary Sword): 전설의 Sword! - 가치: 6200G
사냥꾼의 활 (Rare Bow): Rare Bow (Damage: 45) - 가치: 650G
강철 흉갑 (Epic Chest): 강력한 방어구 - 가치: 1900G
체력 물약 (Common Consumable): HP 회복 (10초 지속) - 가치: 60G

[장착 가능 여부 - Warrior Lv.15]
화염검: 장착 가능
사냥꾼의 활: 클래스 불일치
강철 흉갑: 장착 가능
체력 물약: 사용 가능

[장착 가능 여부 - Mage Lv.8]
화염검: 클래스 불일치
사냥꾼의 활: 클래스 불일치
강철 흉갑: 장착 가능
체력 물약: 사용 가능
```
